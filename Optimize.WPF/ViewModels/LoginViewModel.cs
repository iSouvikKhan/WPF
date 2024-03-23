using Optimize.WPF.Commands;
using Optimize.WPF.Models;
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
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _password;
        private NavigationStore navigationStore;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public ICommand LoginCommand { get; }

        //public LoginViewModel(AccountStore accountStore, INavigationService loginNavigationService)
        //{
        //    LoginCommand = new LoginCommand(this, accountStore, loginNavigationService);
        //}

        public LoginViewModel(AccountStore accountStore, NavigationService<AccountViewModel> accountNavigationService)
        {
            LoginCommand = new LoginCommand(this, accountStore, accountNavigationService);
        }
    }
}
