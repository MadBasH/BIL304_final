using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL304_final
{
    class Admin : Uye, IIlanIslemleri, IIlanOnay
    {
        public int Id { get; set; }

        public override bool Validation()
        {
            throw new NotImplementedException();
        }

        string IIlanIslemleri.Ekle()
        {
            throw new NotImplementedException();
        }

        string IIlanIslemleri.Guncelle()
        {
            throw new NotImplementedException();
        }

        bool IIlanOnay.Onayla()
        {
            throw new NotImplementedException();
        }

        string IIlanIslemleri.Sil()
        {
            throw new NotImplementedException();
        }
        
    }
}
