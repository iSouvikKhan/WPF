﻿using Optimize.WPF.Commands;
using Optimize.WPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class NavigationBarViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateAccountCommand { get; }
        public ICommand NavigateLoginCommand { get; }

        public NavigationBarViewModel(NavigationService<HomeViewModel> homeNavigationService, 
            NavigationService<AccountViewModel> accountNavigationService, 
            NavigationService<LoginViewModel> loginNavigationService
            )
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
            NavigateAccountCommand = new NavigateCommand<AccountViewModel>(accountNavigationService);
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);
        }
    }
}
