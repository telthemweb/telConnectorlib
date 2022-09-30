using System;
using System.Text;
using System.Security.Cryptography;

namespace TelDatabaseManger.Helper
{
    public class TelHelpersdb
    {
        TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
        MD5CryptoServiceProvider M5 = new MD5CryptoServiceProvider();
        string PublicKey = "One day i will conquer the world. God have mercy on my vision";


        /*
        |:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        |                Print md5 hash code algorithim
        |::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        */
        public byte[] Tel_MD5Code(string values)
        {
            return M5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(values));
        }

        /*
       |:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
       |                Encryipt data 
       |::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
       */
        public string TelEncryptData(string StrEncrypt)
        {
            DES.Key = Tel_MD5Code(PublicKey);

            DES.Mode = CipherMode.ECB;
            byte[] buf = ASCIIEncoding.ASCII.GetBytes(StrEncrypt);
            return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buf, 0, buf.Length));
        }


        /*
        |:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        |                Decryipt data 
        |::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        */
        public string TelDecryptData(string DecryptString)
        {
            try
            {
                DES.Key = Tel_MD5Code(PublicKey);
                DES.Mode = CipherMode.ECB;
                byte[] Buff = Convert.FromBase64String(DecryptString);
                return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buff, 0, Buff.Length));
            }
            catch
            {
                return "FALSE";
            }
        }
    }
}
