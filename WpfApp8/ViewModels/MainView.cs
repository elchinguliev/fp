using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using WpfApp8.Messages;
using WpfApp8.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INavigationService = WpfApp8.Service.INavigationService;
namespace WpfApp8.ViewModels
{
    public class MainWindow :ViewModelBase
    {
        private readonly INavigationService navigationService;

        public MainWindow(INavigationService navigationService, IMessenger messenger)
        {
            this.navigationService = navigationService;
            messenger.Register<NavigationMessage>(this, message =>
            {
                var viewModel = App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
                CurrentViewModel = viewModel;
            });
        }
        private ViewModelBase ?currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return currentViewModel; }
            set { Set(ref currentViewModel, value); }
        }

        public RelayCommand RideCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<CreateRideViewModel>();
            });
        }

        public RelayCommand StudentCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<StudenViewModel>();
            });
        }

        public RelayCommand BusDriverCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<DriverViewModel>();
            });
        }

        public RelayCommand BusCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<BusViewModel>();
            });
        }
    }
}
