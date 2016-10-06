using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWP.Encryption
{
    public class pbkdf2Data
    {
        private string Key;
        private string Salt;
        public string key
        {
            set { Key = value; }
            get { return Key; }
        }
        public string salt
        {
            set { Salt = value; }
            get { return Salt; }
        }
    }
}
