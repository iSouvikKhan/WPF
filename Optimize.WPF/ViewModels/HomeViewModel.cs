using Optimize.WPF.Commands;
using Optimize.WPF.Services;
using Optimize.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Optimize.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to Home";

        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(NavigationBarViewModel navigationBarViewModel, NavigationService<LoginViewModel> loginNavigationService)
        {
            NavigationBarViewModel = navigationBarViewModel;

            NavigateAccountCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);
        }
    }
}
