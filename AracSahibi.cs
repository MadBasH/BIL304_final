using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL304_final
{
    class AracSahibi : Uye, IVitrinIslemleri, IIlanIslemleri
    {
        public int id { get; set; }
        public override bool Validation()
        {
            throw new NotImplementedException();
        }

        string IVitrinIslemleri.Olustur()
        {
            throw new NotImplementedException();
        }

        string IVitrinIslemleri.Ara()
        {
            throw new NotImplementedException();
        }

        string IVitrinIslemleri.Goruntule()
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

        string IIlanIslemleri.Sil()
        {
            throw new NotImplementedException();
        }
    }
}
