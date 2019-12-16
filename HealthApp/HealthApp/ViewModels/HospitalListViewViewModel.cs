using HealthApp.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace HealthApp.ViewModels
{
    public class HospitalListViewViewModel : ViewModelBase
    {
        public HospitalListViewViewModel(INavigationService navigationService) : base(navigationService)
        {
            LoadHospitalData = new DelegateCommand(LoadHospitalDataExecute);
            LoadHospitalDataExecute();
        }

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
        public void LoadHospitalDataExecute()
        {
            //TODO: load hospistal  data from database via API

            this.hospitals.Add(new Hospital
            {
                Name = "Bệnh Viện Y Học Cổ Truyền",
                Address = "179 Nam Kỳ Khởi Nghĩa, P.7, Q.3, Thành Phố Hồ Chí Minh"
            });

            this.hospitals.Add(new Hospital
            {
                Name = "Bệnh Viện Chấn Thương Chỉnh Hình",
                Address = "929 Trần Hưng Đạo, Phường 1, Quận 5, Thành Phố Hồ Chí Minh"
            });

            this.hospitals.Add(new Hospital
            {
                Name = "Bệnh Viện Nhiệt Đới",
                Address = "190 Hàm Tử, Phường 1, Quận 5, Thành Phố Hồ Chí Minh"
            });

            this.hospitals.Add(new Hospital
            {
                Name = "Bệnh Viện Da Liễu",
                Address = "2 Nguyễn Thông, Phường 6, Quận 3, Thành Phố Hồ Chính Minh"
            });

            this.hospitals.Add(new Hospital
            {
                Name = "Bệnh Viện Mắt",
                Address = "280 Điện Biên Phủ, P.7, Q.3, Thành Phố Hồ Chí Minh"
            });

        }
    }
}
