using Optimize.WPF.Services;
using Optimize.WPF.Stores;
using Optimize.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Optimize.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly NavigationBarViewModel _navigationBarViewModel;

        public App()
        {
            _navigationStore = new NavigationStore();
            _navigationBarViewModel = new NavigationBarViewModel(
                CreateHomeNavigationService(),
                CreateAccountNavigationService(),
                CreateLoginNavigationService(),
                CreatePerformanceNavigationService()
                );
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationBarViewModel);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();


            base.OnStartup(e);
        }

        private NavigationService<HomeViewModel> CreateHomeNavigationService()
        {
            return new NavigationService<HomeViewModel>(
                _navigationStore, 
                () => new HomeViewModel(_navigationBarViewModel));
        }

        private NavigationService<LoginViewModel> CreateLoginNavigationService()
        {
            return new NavigationService<LoginViewModel>(_navigationStore, () => new LoginViewModel(_navigationBarViewModel));
        }

        private NavigationService<AccountViewModel> CreateAccountNavigationService()
            {
            return new NavigationService<AccountViewModel>(_navigationStore, () => new AccountViewModel(_navigationBarViewModel));
        }

        private NavigationService<PerformanceViewModel> CreatePerformanceNavigationService()
        {
            return new NavigationService<PerformanceViewModel>(_navigationStore, () => new PerformanceViewModel(_navigationBarViewModel));
        }
    }
}
