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
    [Persistent(@"Hospitals")]
    [DefaultClassOptions]
    [XafDisplayName("Bệnh Viện")]
    public class Hospitals : BaseObject
    {
        public Hospitals(Session session) : base(session) { }

        private string _name;
        [XafDisplayName("Tên Bệnh Viện")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private string _address;
        [XafDisplayName("Địa Chỉ")]
        public string address
        {
            get => _address;
            set => SetPropertyValue(nameof(address), ref _address, value);
        }

        private string _phone;
        [XafDisplayName("Điện Thoại")]
        public string phone
        {
            get => _phone;
            set => SetPropertyValue(nameof(phone), ref _phone, value);
        }
    }
}
