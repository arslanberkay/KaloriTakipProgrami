using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgrami.UI.Helpers
{
    public class SifrelemeHelper //Şifreleme işlemlerini gerçekleştirmek için kullanılacak olan yardımcı (helper) sınıf
    {
        /// <summary>
        /// İçine aldığı string türünde parametreyi alır ve geriye şifrelenmiş string halini döner.
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public static string Sha256Hash(string sifre) //Doğrudan sınıf üzerinden çağırılması için static (Nesne oluşturmadan) 
        {
            using (SHA256 hash = SHA256Managed.Create()) //SHA-256 algoritmasını kullanmak için SHA256Managed sınıfından nesne oluşturur.
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }
}

