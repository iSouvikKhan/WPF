using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to Account";

        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigatePerformanceCommand { get; }


        public AccountViewModel(NavigationBarViewModel navigationBarViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
        }
    }
}