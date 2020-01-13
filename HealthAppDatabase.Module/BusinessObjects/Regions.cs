using System;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace HealthAppDatabase.Module.BusinessObjects
{
    [Persistent("Regions")]
    [XafDisplayName("Khu Vực")]
    [XafDefaultProperty(nameof(name))]
    [DefaultClassOptions]
    public class Regions : XPLiteObject
    {
        public Regions(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private int _Oid;
        [Key(true)]
        [XafDisplayName("STT")]
        public int Oid
        {
            get => _Oid;
            set => SetPropertyValue(nameof(Oid), ref _Oid, value);
        }

        private string _name;
        [XafDisplayName("Tên Khu Vực")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        private string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }

        [XafDisplayName("Bệnh Viện")]
        [Association("Hospital-Region")]
        public XPCollection<Hospitals> hospitals => GetCollection<Hospitals>(nameof(hospitals));

    }
}