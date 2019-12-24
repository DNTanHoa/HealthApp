using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace HealthAppAPI.Models
{
    public partial class SystemUsers
    {
        public SystemUsers()
        {
            this.Oid = Guid.NewGuid();
        }

        public Guid Oid { get; set; }
        public string Username { get; set; }
        public string StoredPassword { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        [NotMapped]
        public string password
        {
            get => Decrypt(this.StoredPassword);
            set
            {
                if (value != null)
                    this.StoredPassword = Encrypt(value.ToString());
            }
        }

        #region suport function
        public string Decrypt(string input)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(this.Oid.ToString()));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(input);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }

        public string Encrypt(string input)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(this.Oid.ToString()));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(input);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }
        #endregion
    }
}
