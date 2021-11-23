using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempoMVVM.Core.Models;

namespace TempoMVVM.Core.Services
{
    public interface IWeatherService
    {
        //http://api.weatherapi.com/v1/current.json?key=b52d0588a52740cc87621810212311&q=paracampos-rio-de-janeiro-brazil&aqi=no

        [Get("/current.json?key=b52d0588a52740cc87621810212311&q={parameter}&aqi=no&lang=pt")]
        Task<CurrentWeatherResponse> GetCurrentWeatherAsync(string parameter);
    }
}
