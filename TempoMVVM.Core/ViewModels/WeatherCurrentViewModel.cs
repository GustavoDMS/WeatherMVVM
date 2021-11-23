using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempoMVVM.Core.Models;
using TempoMVVM.Core.Services;

namespace TempoMVVM.Core.ViewModels
{
    public class WeatherCurrentViewModel : ObservableRecipient
    {
        private WeatherModel weather;
        public WeatherModel Weather
        {
            get => weather;
            set => SetProperty(ref weather, value);
        }
        public IAsyncRelayCommand LoadWeatherCommand { get; }
        private IWeatherService WeatherService = Ioc.Default.GetRequiredService<IWeatherService>();

        public WeatherCurrentViewModel()
        {
            LoadWeatherCommand = new AsyncRelayCommand(LoadWeatherAsync);
        }

        private async Task LoadWeatherAsync()
        {
            var response = await WeatherService.GetCurrentWeatherAsync("rio-das-ostras-rio-de-janeiro-brazil");
            Weather = new WeatherModel();
            Weather.Current = response.CurrentWeather;
            Weather.Location = response.LocationInfo;

        }
    }
}
