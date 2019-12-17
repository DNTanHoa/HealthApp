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
        }

        public static EasternMedicineView instance;
    }
}