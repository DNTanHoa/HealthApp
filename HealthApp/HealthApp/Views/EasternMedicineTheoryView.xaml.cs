using Xamarin.Forms;

namespace HealthApp.Views
{
    public partial class EasternMedicineTheoryView : EasternMedicineBaseContent
    {
        public EasternMedicineTheoryView()
        {
            InitializeComponent();
            EasternMedicineView view = EasternMedicineView.instance;
            this.master = view as MasterDetailPage;
        }
    }
}
