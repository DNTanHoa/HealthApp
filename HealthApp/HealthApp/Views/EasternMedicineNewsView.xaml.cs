using Xamarin.Forms;

namespace HealthApp.Views
{
    public partial class EasternMedicineNewsView : EasternMedicineBaseContent
    {
        public EasternMedicineNewsView()
        {
            InitializeComponent();
            EasternMedicineView view = EasternMedicineView.instance;
            this.master = view as MasterDetailPage;
        }
    }
}
