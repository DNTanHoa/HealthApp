using HealthApp.Models;
using HealthApp.Service;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthApp.ViewModels
{
    public class HospitalListViewViewModel : ViewModelBase, IActiveAware
    {
        public HospitalListViewViewModel(INavigationService navigationService) : base(navigationService)
        {
            LoadHospitalData = new DelegateCommand(async() => await LoadHospitalDataExecute());
            FindRoute = new DelegateCommand(FindRouteExecute);
            service = new HospitalService();
        }

        public HospitalService service;

        private List<Hospital> _hospitals = new List<Hospital>();
        public List<Hospital> hospitals
        {
            get => _hospitals;
            set
            {
                SetProperty(ref _hospitals, value);
                RaisePropertyChanged(nameof(hospitals));
            }
        }

        public DelegateCommand LoadHospitalData { get; }
        public async Task LoadHospitalDataExecute()
        {
            this.hospitals = await service.RefreshDataAsync();
        }

        public DelegateCommand FindRoute { get; }
        public void FindRouteExecute()
        {
            //TODO: get hospital location information and bind to Map View
            NavigationService.NavigateAsync("MapScreenView");
        }

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value, RaiseIsActiveChanged); }
        }

        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
            if(this.IsActive)
            {
                LoadHospitalDataExecute().GetAwaiter();
            }
        }
    }
}
