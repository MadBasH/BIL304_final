using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL304_final
{
    class Musteri : Uye, IIlanKarsilastirma, IVitrinIslemleri, IYorum
    {
        public int id { get; set; }

        public override bool Validation()
        {
            throw new NotImplementedException();
        }

        string IVitrinIslemleri.Ara()
        {
            throw new NotImplementedException();
        }

        string IIlanKarsilastirma.Ara()
        {
            throw new NotImplementedException();
        }

        string IVitrinIslemleri.Goruntule()
        {
            throw new NotImplementedException();
        }

        string IIlanKarsilastirma.Goruntule()
        {
            throw new NotImplementedException();
        }

        string IIlanKarsilastirma.Karsilastir()
        {
            throw new NotImplementedException();
        }

        string IVitrinIslemleri.Olustur()
        {
            throw new NotImplementedException();
        }

        string IYorum.YorumYap()
        {
            throw new NotImplementedException();
        }
    }
}
