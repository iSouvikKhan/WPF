using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        public string WelcomeMessage => "Welcome to Login";

        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ICommand NavigateAccountCommand { get; }
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigatePerformanceCommand { get; }

        public LoginViewModel(NavigationBarViewModel navigationBarViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
        }
    }
}
