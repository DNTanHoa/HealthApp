using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace HealthApp.ViewModels
{
    public class EasternMedicineBaseContentViewModel : ViewModelBase
    {
        public EasternMedicineBaseContentViewModel(INavigationService navigationService) : base(navigationService)
        {
            ShowMasterMenu = new DelegateCommand(ShowMasterMenuExecute);
        }

        private MasterDetailPage _master;
        public MasterDetailPage master
        {
            get => _master;
            set
            {
                SetProperty(ref _master, value);
                RaisePropertyChanged(nameof(master));
            }
        }

        public DelegateCommand ShowMasterMenu { get;  }

        public void ShowMasterMenuExecute()
        {
            if(this.master != null)
            {
                this.master.IsPresented = true;
            }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            this.master = parameters.GetValue<MasterDetailPage>("master");
        }
    }
}
