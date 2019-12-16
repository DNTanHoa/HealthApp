using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
    public class EasterMedicineDoctorViewViewModel : ViewModelBase
    {
        public EasterMedicineDoctorViewViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Thầy Thuốc Đông Y";
        }
    }
}
