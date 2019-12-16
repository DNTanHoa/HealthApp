using HealthApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthApp.ViewModels
{
    public class EasternMedicineViewViewModel : ViewModelBase
    {
        public EasternMedicineViewViewModel(INavigationService navigationService) : base(navigationService)
        {
            ShowSelectedDetailPage = new DelegateCommand(async () => await ShowSelectedDetailPageExecute());
            HideMasterContent = new DelegateCommand(HideMasterContentExecute);
        }

        private EasternMedicineItem _selectedItem;
        public EasternMedicineItem selectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                RaisePropertyChanged(nameof(selectedItem));
            }
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

        public DelegateCommand ShowSelectedDetailPage { get; }

        public async Task ShowSelectedDetailPageExecute()
        {
            if(selectedItem != null)
            {
                await NavigationService.NavigateAsync(selectedItem.page.Name);
                this.selectedItem = null;
            }
        }

    }
}
