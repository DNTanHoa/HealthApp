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
    [XafDisplayName("Nội Dung Bài")]
    [XafDefaultProperty(nameof(title))]
    public class PostContent : XPLiteObject
    {
        public PostContent (Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _title;
        [XafDisplayName("Tiêu Đề")]
        public string title
        {
            get => _title;
            set => SetPropertyValue(nameof(title), ref _title, value);
        }

        private string _content;
        [XafDisplayName("Nội Dung")]
        [Size(2000)]
        public string content
        {
            get => _content;
            set => SetPropertyValue(nameof(content), ref _content, value);
        }

        private Post _post;
        [XafDisplayName("Bài Viết")]
        [Association("Post-Content")]
        public Post post
        {
            get => _post;
            set => SetPropertyValue(nameof(post), ref _post, value);
        }
    }
}
