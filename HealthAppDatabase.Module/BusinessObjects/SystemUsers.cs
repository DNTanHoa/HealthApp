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
    [Persistent(@"SystemUsers")]
    [XafDisplayName("Người Dùng")]
    [DefaultClassOptions]
    [XafDefaultProperty(nameof(username))]
    public class SystemUsers : BaseObject
    {
        public SystemUsers(Session session) : base(session) { }

        private string _username;
        [XafDisplayName("Tên Đăng Nhập")]
        public string username
        {
            get => _username;
            set => SetPropertyValue(nameof(username), ref _username, value);
        }

        private string _storedPassword;
        [XafDisplayName("Mật Khẩu")]
        public string storedPassword
        {
            get => _storedPassword;
            set => SetPropertyValue(nameof(storedPassword), ref _storedPassword, value);
        }

        private string _fullName;
        [XafDisplayName("Họ Tên")]
        public string fullName
        {
            get => _fullName;
            set => SetPropertyValue(nameof(fullName), ref _fullName, value);
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
