using Prism.Navigation;
using Xamarin.Forms;

namespace HealthApp.Views
{
    public partial class EasternMedicineView : MasterDetailPage
    {
        public EasternMedicineView()
        {
            InitializeComponent();

            instance = this;
            EasternMedicineTheoryView firstView = new EasternMedicineTheoryView();
            firstView.master = this;
            Detail = new NavigationPage((Page)firstView);
        }

        public static EasternMedicineView instance;
    }
}