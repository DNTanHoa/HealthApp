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

        private Regions _region;
        [XafDisplayName("Khu Vực")]
        [Association("Hospital-Region")]
        public Regions region
        {
            get => _region;
            set => SetPropertyValue(nameof(region), ref _region, value);
        }

        private string _phone;
        [XafDisplayName("Điện Thoại")]
        public string phone
        {
            get => _phone;
            set => SetPropertyValue(nameof(phone), ref _phone, value);
        }

        #region Position

        private double _longitude;
        [XafDisplayName("Kinh Độ")]
        public double longitude
        {
            get => _longitude;
            set => SetPropertyValue(nameof(longitude), ref _longitude, value);
        }

        private double _latitude;
        [XafDisplayName("Vĩ Độ")]
        public double latitude
        {
            get => _latitude;
            set => SetPropertyValue(nameof(latitude), ref _latitude, value);
        }
        #endregion
    }
}
