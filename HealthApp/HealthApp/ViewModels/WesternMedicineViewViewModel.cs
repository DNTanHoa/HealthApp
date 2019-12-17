using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.ViewModels
{
    public class WesternMedicineViewViewModel : ViewModelBase
    {
        public WesternMedicineViewViewModel(INavigationService navigationService) : base(navigationService)
        {
            HideMasterContent = new DelegateCommand(HideMasterContentExecute);
        }

        private bool _isMasterPresented;
        public bool isMasterPresented
        {
            get => _isMasterPresented;
            set
            {
                SetProperty(ref _isMasterPresented, value);
                RaisePropertyChanged(nameof(isMasterPresented));
            }
        }

        public DelegateCommand HideMasterContent { get; }

        public void HideMasterContentExecute()
        {
            this.isMasterPresented = false;
        }
    }
}
