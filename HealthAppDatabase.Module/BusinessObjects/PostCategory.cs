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
    [XafDisplayName("Danh Mục Bài Viết")]
    [XafDefaultProperty(nameof(name))]
    [DefaultClassOptions]
    [Persistent("PostCategory")]
    public class PostCategory : BaseObject
    {
        public PostCategory(Session session): base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _name;
        [XafDisplayName("Tên Danh Mục")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }

        [Association("Category-Post")]
        [XafDisplayName("Bài Viết")]
        public XPCollection<Post> posts => GetCollection<Post>(nameof(posts));
    }
}
