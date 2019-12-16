using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthApp.ViewModels
{
    public class SplashScreenViewViewModel : ViewModelBase
    {
        public SplashScreenViewViewModel(INavigationService navigationService):base(navigationService)
        {
            CallLoginCommand = new DelegateCommand( async() => await(CallLoginCommandExecute()));
            CallSignUpCommand = new DelegateCommand( async() => await(CallSignUpCommandExecute()));
        }

        public DelegateCommand CallLoginCommand { get;  }
        public async Task CallLoginCommandExecute()
        {
            await NavigationService.NavigateAsync("LoginScreenView");
        }

        public DelegateCommand CallSignUpCommand { get; }
        public async Task CallSignUpCommandExecute()
        {
            await NavigationService.NavigateAsync("SignupScreenView");
        }

    }
}
