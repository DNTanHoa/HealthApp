using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
    public class EasternMedicineNewsViewViewModel : ViewModelBase
    {
        public EasternMedicineNewsViewViewModel(INavigationService navigationService):base(navigationService)
        {
            Title = "Tin Tức Đông Y";
        }
    }
}
