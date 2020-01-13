using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAppDatabase.Module.BusinessObjects
{
    [Persistent("Post")]
    [DefaultClassOptions]
    [XafDisplayName("Bài Viết")]
    [XafDefaultProperty(nameof(title))]
    public class Post : XPLiteObject
    {
        public Post(Session session) : base(session) { }

        private string _title;
        [XafDisplayName("Tiêu Đề")]
        public string title
        {
            get => _title;
            set => SetPropertyValue(nameof(title), ref _title, value);
        }

        private int _Oid;
        [Key(true)]
        [XafDisplayName("STT")]
        public int Oid
        {
            get => _Oid;
            set => SetPropertyValue(nameof(Oid), ref _Oid, value);
        }

        private string _summary;
        [XafDisplayName("Tóm Tắt")]
        public string summary
        {
            get => _summary;
            set => SetPropertyValue(nameof(summary), ref _summary, value);
        }

        private PostCategory _category;
        [XafDisplayName("Danh Mục")]
        [Association("Category-Post")]
        public PostCategory category
        {
            get => _category;
            set => SetPropertyValue(nameof(category), ref _category, value);
        }

        [Association("Post-Content")]
        [XafDisplayName("Nội Dung Bài Viết")]
        public XPCollection<PostContent> postContents => GetCollection<PostContent>(nameof(postContents));
    }
}
