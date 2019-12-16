using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
    public class EasterMedicinePaperViewViewModel : ViewModelBase
    {
        public EasterMedicinePaperViewViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Bài Thuốc Đông Y";
        }
    }
}
