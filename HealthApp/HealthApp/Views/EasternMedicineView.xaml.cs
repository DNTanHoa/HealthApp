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
            this.IsPresented = true;
        }

        public static EasternMedicineView instance;
    }
}