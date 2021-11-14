using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class OpenWeatherService : IWindDataService
    {
        private OpenWeatherProcessor owp;

        public WindDataModel LastWindData;
        public async Task<WindDataModel> GetDataAsync()
        {
            OWCurrentWeaterModel owc = await owp.GetCurrentWeatherAsync();
            WindDataModel windDataModel = new WindDataModel();
            windDataModel.DateTime = DateTime.UnixEpoch.AddSeconds(owc.DateTime);
            windDataModel.Direction = owc.Wind.Deg;
            windDataModel.MetrePerSec = owc.Wind.Speed;
            LastWindData = windDataModel;
            return LastWindData;
        }

        public OpenWeatherService(string apiKey)
        {
            owp = OpenWeatherProcessor.Instance;
            owp.ApiKey = apiKey;
        }
    }
}
