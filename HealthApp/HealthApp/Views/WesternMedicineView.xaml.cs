using Xamarin.Forms;

namespace HealthApp.Views
{
    public partial class WesternMedicineView : MasterDetailPage
    {
        public WesternMedicineView()
        {
            InitializeComponent();

            instance = this;
            WesternMedicineFirstAidView detail = new WesternMedicineFirstAidView();
            detail.master = this;
            Detail = new NavigationPage((Page)detail);
        }

        public static WesternMedicineView instance;
    }
}