using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
    public class EasternMedicineTheoryViewViewModel : ViewModelBase
    {
        public EasternMedicineTheoryViewViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Khái Niệm Đông Y";
        }
    }
}
