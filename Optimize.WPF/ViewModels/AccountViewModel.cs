using Optimize.WPF.Commands;
using Optimize.WPF.Models;
using Optimize.WPF.Services;
using Optimize.WPF.Stores;
using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to Account";

        private readonly AccountStore _accountStore;

        public string Username => _accountStore.CurrentAccount?.Username;
        public string Email => _accountStore.CurrentAccount?.Email;

        public ICommand NavigateHomeCommand { get; }
        public NavigationBarViewModel NavigationBarViewModel { get; }

        public AccountViewModel(NavigationBarViewModel navigationBarViewModel, AccountStore accountStore, NavigationService<HomeViewModel> homeNavigationService)
        {
            NavigationBarViewModel = navigationBarViewModel;
            _accountStore = accountStore;

            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
        }
    }
}