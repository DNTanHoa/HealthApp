using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAppDatabase.Module.BusinessObjects
{
    [Persistent(@"SystemRoles")]
    [DefaultClassOptions]
    [XafDisplayName("Phân Quyền")]
    public class SystemRoles : BaseObject
    {
        public SystemRoles(Session session) : base(session) { }

        private string _name;
        [XafDisplayName("Tên Quyền")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }
    }
}
