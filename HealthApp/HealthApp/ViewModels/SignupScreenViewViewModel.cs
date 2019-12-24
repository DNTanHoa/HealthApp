using HealthApp.Models;
using HealthApp.Service;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthApp.ViewModels
{
    public class SignupScreenViewViewModel : ViewModelBase
    {
        public SignupScreenViewViewModel(INavigationService service) : base(service)
        {
            RegisterCommand = new DelegateCommand(async () => await RegisterCommandExecute());
            _service = new SystemUserService();
        }

        public SystemUserService _service;

        private string _fullName;
        public string fullName
        {
            get => _fullName;
            set
            {
                SetProperty(ref _fullName, value);
                RaisePropertyChanged(nameof(fullName));
            }    
        }

        private string _email;
        public string email
        {
            get => _email;
            set
            {
                SetProperty(ref _email, value);
                RaisePropertyChanged(nameof(email));
            }
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

        public DelegateCommand RegisterCommand { get; }

        public async Task RegisterCommandExecute()
        {
            SystemUsers newUser = new SystemUsers
            {
                FullName = this.fullName,
                Username = this.username,
                password = this.password
            };

            await _service.RegisterUser(newUser);
        }
    }
}
