using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
   public class Cikartma1:Chain
    {
        public int sonuc;
        private Chain nextchain;
        public void Hesapla(Sayilar istek)
        {
            if (istek.Islemtürü == "çıkar")
            {
                sonuc= istek.Sayi1 - istek.Sayi2;
            }
            else
            {
                nextchain.Hesapla(istek);
                
            }


          

        }

        public void SonrakiZincir(Chain nextchain)
        {
            this.nextchain = nextchain;
        }
    }
}
