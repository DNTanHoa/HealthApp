using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
	public class HomeScreenViewViewModel : ViewModelBase
	{
        public HomeScreenViewViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
	}
}
