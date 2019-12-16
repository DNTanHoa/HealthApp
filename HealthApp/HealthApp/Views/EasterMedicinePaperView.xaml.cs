using Xamarin.Forms;

namespace HealthApp.Views
{
    public partial class EasterMedicinePaperView : EasternMedicineBaseContent
    {
        public EasterMedicinePaperView()
        {
            InitializeComponent();
            EasternMedicineView view = EasternMedicineView.instance;
            this.master = view as MasterDetailPage;
        }
    }
}
