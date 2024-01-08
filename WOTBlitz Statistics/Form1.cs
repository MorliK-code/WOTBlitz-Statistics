using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;

namespace WOTBlitz_Statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(form1_load);
        }
        int firstBattles;
        int firstWins;
        int firstDamage;
        int sessionDamage;
        string url = "https://api.wotblitz.eu/wotb/account/info/?application_id=6df7e8b20d7ca3807b4cab80fa418209&account_id=594732188";

        private void form1_load(object sender, EventArgs e)
        {
            if ()
            button1_Click(sender, e);
            string filePath = Path.Combine(Application.StartupPath, "allStatsForSession.txt");
            string[] lines = File.ReadAllLines(filePath);
            firstBattles = int.Parse(lines[0].Split(':')[1].Trim());
            firstWins = int.Parse(lines[1].Split(':')[1].Trim());
            firstDamage = int.Parse(lines[2].Split(':')[1].Trim());
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    string accountId = ((JObject)json["data"]).Properties().Select(p => p.Name).FirstOrDefault();
                    JObject accountData = (JObject)json["data"][accountId]["statistics"]["all"];

                    firstBattles = accountData["battles"].Value<int>();
                    firstWins = accountData["wins"].Value<int>();
                    firstDamage = accountData["damage_dealt"].Value<int>();
                    string filePath = Path.Combine(Application.StartupPath, "allStatsForSession.txt");
                    File.WriteAllText(filePath, $"FirstBattles: {firstBattles}\nFirstWins: {firstWins}\nFirstDamage: {firstDamage}");
                }
                catch (HttpRequestException ex) { Console.WriteLine($"Ошибка: {ex.Message}"); }
                button1_Click(sender, e);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    string accountId = ((JObject)json["data"]).Properties().Select(p => p.Name).FirstOrDefault();
                    JObject accountData = (JObject)json["data"][accountId]["statistics"]["all"];

                    int reloadBattles = accountData["battles"].Value<int>();
                    int reloadWins = accountData["wins"].Value<int>();
                    int reloadDamage = accountData["damage_dealt"].Value<int>();

                    int sessionBattles = reloadBattles - firstBattles;
                    int sessionWins = reloadWins - firstWins;
                    double sessionWinRate = 0;
                    if (sessionWinRate > 0) { sessionWinRate = ((double)sessionWins / (double)sessionBattles) * 100; }
                    if (sessionBattles > 0) { sessionDamage = (reloadDamage - firstDamage) / sessionBattles; }
                    else { sessionDamage = 0; }


                    textBox1.Text = sessionBattles.ToString();
                    textBox2.Text = sessionWinRate.ToString() + "%";
                    textBox3.Text = sessionDamage.ToString();
                }
                catch (HttpRequestException ex) { Console.WriteLine($"Ошибка: {ex.Message}"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}