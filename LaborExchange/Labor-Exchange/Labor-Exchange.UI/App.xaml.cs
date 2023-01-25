﻿using Microsoft.Extensions.DependencyInjection;
using Labor_Exchange.Infrastructure;
using System.Windows;

namespace Labor_Exchange.UI
{
    public partial class App : System.Windows.Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {
            var services = new ServiceCollection();
            services.AddSingleton<MainWindow>();
            services.AddInfrastructure();
            services.AddServices();
            this._serviceProvider = services.BuildServiceProvider();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = this._serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
