using HealthApp.ViewModels;
using HealthApp.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HealthApp
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginScreenView");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SplashScreenView, SplashScreenViewViewModel>();
            containerRegistry.RegisterForNavigation<MapScreenView, MapScreenViewViewModel>();
            containerRegistry.RegisterForNavigation<HospitalListView, HospitalListViewViewModel>();
            containerRegistry.RegisterForNavigation<LoginScreenView, LoginScreenViewViewModel>();
            containerRegistry.RegisterForNavigation<SignupScreenView, SignupScreenViewViewModel>();
            containerRegistry.RegisterForNavigation<EasternMedicineView, EasternMedicineViewViewModel>();
            containerRegistry.RegisterForNavigation<EasternMedicineTheoryView, EasternMedicineTheoryViewViewModel>();
            containerRegistry.RegisterForNavigation<EasterMedicinePaperView, EasterMedicinePaperViewViewModel>();
            containerRegistry.RegisterForNavigation<EasternMedicineNewsView, EasternMedicineNewsViewViewModel>();
            containerRegistry.RegisterForNavigation<EasterMedicineZenView, EasterMedicineZenViewViewModel>();
            containerRegistry.RegisterForNavigation<EasterMedicineDoctorView, EasterMedicineDoctorViewViewModel>();
            containerRegistry.RegisterForNavigation<EasternMedicineBaseContent, EasternMedicineBaseContentViewModel>();
            containerRegistry.RegisterForNavigation<MainView, MainViewViewModel>();
            containerRegistry.RegisterForNavigation<WesternMedicineBaseContent, WesternMedicineBaseContentViewModel>();
            containerRegistry.RegisterForNavigation<WesternMedicineView, WesternMedicineViewViewModel>();
        }
    }
}
