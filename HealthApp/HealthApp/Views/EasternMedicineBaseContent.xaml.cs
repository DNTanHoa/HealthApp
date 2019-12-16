using Xamarin.Forms;

namespace HealthApp.Views
{
    public partial class EasternMedicineBaseContent : ContentPage
    {
        public EasternMedicineBaseContent()
        {
            InitializeComponent();
            EasternMedicineView view = EasternMedicineView.instance;
            this.master = view as MasterDetailPage;
        }

        private static MasterDetailPage _master;
        public MasterDetailPage master
        {
            get => _master;
            set => _master = value;
        }

        private void ShowMaster(object sender, System.EventArgs e)
        {
            if (master != null)
            {
                master.IsPresented = true;
            }
        }
    }
}
