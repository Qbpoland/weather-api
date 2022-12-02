using System.Net;
using System.Text.Json;
using System.Xml.Linq;

namespace weather_api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wmo_Click(object sender, EventArgs e)
        {

        }

        private void wind_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void get_data_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync("https://api.open-meteo.com/v1/forecast?latitude=54.35&longitude=18.65&current_weather=true").Result;
            JsonDocument document = JsonDocument.Parse(response);
            JsonElement current_weather = document.RootElement.GetProperty("current_weather");
            temp.Text = current_weather.GetProperty("temperature").ToString() + "℃";
            wind.Text = current_weather.GetProperty("windspeed").ToString() + "m/s";
            date.Text = current_weather.GetProperty("time").ToString();

            switch (current_weather.GetProperty("weathercode").ToString()[0])
            {
                case '0':
                    wmo.Text = "czyste niebo";
                    break;
                case '1':
                    wmo.Text = "leekkie zachmurzenie";
                    break;
                case '2':
                    wmo.Text = "średnie zachmurzenie ";
                    break;
                case '3':
                    wmo.Text = "pochmurnie";
                    break;
                case '4':
                    wmo.Text = "mgła";
                    break;
                case '5':
                    wmo.Text = "mżawka";
                    break;
                case '6':
                    wmo.Text = "opady deszczu";
                    break;
                case '7':
                    wmo.Text = "Opady śniegu";
                    break;
                case '8':
                    wmo.Text = "Ulewny deszcz";
                    break;
                case '9':
                    wmo.Text = "Burza";
                    break;

            }





        }

        private void temp_TextChanged(object sender, EventArgs e)
        {

        }

        private void wmo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}