using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PWP.Encryption
{
    public class pbkdf2
    {
        public static void main(string[] passwordargs)
        {
            if (passwordargs.Length == 0)
            {

            }
            else
            {
                string pwd1 = passwordargs[0];
                //创建一个Byte数组用于存放随机数
                byte[] salt1 = new byte[8];
                using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
                {
                    //使用随机数填充数组
                    rngCsp.GetBytes(salt1);
                }
            }
        }
    }
}
