using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Refit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TempoMVVM.Core.Services;
using TempoMVVM.Core.ViewModels;

namespace TempoMVVM.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                .AddSingleton(RestService.For<IWeatherService>("http://api.weatherapi.com/v1"))
                .AddTransient<WeatherCurrentViewModel>()
                .BuildServiceProvider());
        }
    }
}
