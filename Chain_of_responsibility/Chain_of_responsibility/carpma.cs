using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    class carpma: Chain
    {
        private Chain nextchain;
        public int sonuc;
        public void Hesapla(Sayilar istek)
        {
            if (istek.Islemtürü == "çarpma")
            {
                sonuc= istek.Sayi1 * istek.Sayi2;
            }
            else
            {
                sonuc = 1;
            }


          

        }

        public void SonrakiZincir(Chain nextchain)
        {
            this.nextchain = nextchain;
        }
    }
}
