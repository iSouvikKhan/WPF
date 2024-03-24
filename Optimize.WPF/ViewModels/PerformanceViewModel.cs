using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class PerformanceViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to Performance";

        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigateAccountCommand { get; }

        public PerformanceViewModel(NavigationBarViewModel navigationBarViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
        }
    }
}
