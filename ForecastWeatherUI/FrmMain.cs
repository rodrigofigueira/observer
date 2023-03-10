using ForecastWeather.Classes;
using ForecastWeather.Interfaces;

namespace ForecastWeatherUI
{
    public partial class FrmMain : Form
    {

        ISubject weatherStation = null!;
        TemperatureDisplay temperatureDisplay = null!;
        WindDisplay windDisplay = null!;

        public FrmMain(ISubject _weatherStation)
        {
            InitializeComponent();
            weatherStation = _weatherStation;
            temperatureDisplay = new(weatherStation);
            windDisplay = new(weatherStation);
        }

        private async void BtnGetWeatherData_Click(object sender, EventArgs e)
        {
            await weatherStation.GetData();

            MostrarDadosDaTemperatura();
            MostrarDadosDoVento();
        }

        private void MostrarDadosDaTemperatura()
        {
            var (temp, feelslike, tempMin, tempMax) = temperatureDisplay.Display();

            TxtTempAtual.Text = temp.ToString();
            TxtSensacaoTermica.Text = feelslike.ToString();
            TxtTempMinima.Text = tempMin.ToString();
            TxtTemMaxima.Text = tempMax.ToString();
        }

        private void MostrarDadosDoVento()
        {
            var (speed, degree, gust) = windDisplay.Display();

            TxtVelocidadeVento.Text = speed.ToString();
            TxtGrausVento.Text = degree.ToString();
            TxtRajadasVento.Text = gust.ToString();
        }
        
    }
}