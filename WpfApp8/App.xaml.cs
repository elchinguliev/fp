using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using WpfApp8.Service;
using WpfApp8.ViewModels;
using WpfApp8.Views;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Container = SimpleInjector.Container;
using INavigationService = WpfApp8.Service.INavigationService;
namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; }
        public static Container Containerr { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
            Window window = new MainView();
            var viewModel = Container.GetInstance<MainView>();
            window.DataContext = viewModel;
            window.ShowDialog();
            base.OnStartup(e);
        }

        private void Register()
        {
            Container = new Container();
            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<MainWindow>();
            Container.RegisterSingleton<CreateRideViewModel>();
            Container.RegisterSingleton<StudenViewModel>();
            Container.RegisterSingleton<DriverViewModel>();
            Container.RegisterSingleton<BusViewModel>();
            Container.Verify();

        }
    }
}
