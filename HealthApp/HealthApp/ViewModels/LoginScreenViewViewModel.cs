using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthApp.ViewModels
{
    public class LoginScreenViewViewModel : ViewModelBase
    {
        public LoginScreenViewViewModel(INavigationService navigationService):base(navigationService)
        {
            LoginCommand = new DelegateCommand(async() => await LoginCommandExecute());
        }

        private string _username;
        public string username
        {
            get => _username;
            set
            {
                SetProperty(ref _username, value);
                RaisePropertyChanged(nameof(username));
            }
        }

        private string _password;
        public string password
        {
            get => _password;
            set
            {
                SetProperty(ref _password, value);
                RaisePropertyChanged(nameof(password));
            }
        }

        public DelegateCommand LoginCommand { get; }

        public async Task LoginCommandExecute()
        {
            //TODO: call api to get login
            if(username != "admin" || password != "admin")
            {
                await Application.Current.MainPage.DisplayAlert("Đăng Nhập", 
                                                                "Tên Đăng Nhập Hoặc Mật Khẩu Không Hợp Lệ", 
                                                                "Xác Nhận");
            }
            else
            {
                await NavigationService.NavigateAsync("MainView");
            }
        }
    }
}
