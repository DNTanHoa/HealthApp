using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.TabbedPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
    public class MainViewViewModel : ViewModelBase
    {

        public MainViewViewModel(INavigationService service) : base(service)
        {

        }

    }
}
