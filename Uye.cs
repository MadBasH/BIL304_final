using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL304_final
{
    public abstract class Uye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public abstract bool Validation();
    }
}
