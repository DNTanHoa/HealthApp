using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
    public class EasterMedicineZenViewViewModel : ViewModelBase
    {
        public EasterMedicineZenViewViewModel(INavigationService navigationService):base(navigationService)
        {
            Title = "Thiền Học Đông Y";
        }
    }
}
