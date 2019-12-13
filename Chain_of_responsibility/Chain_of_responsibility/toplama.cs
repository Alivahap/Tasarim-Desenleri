using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    class toplama : Chain
    {
        public int sonuc;

        private Chain nextchain;
        public void Hesapla(Sayilar istek)
        {
            if (istek.Islemtürü != "topla")
            {
                nextchain.Hesapla(istek);

              
            }
            else
            {


                sonuc= istek.Sayi1 + istek.Sayi2;

            }


           

        }

        public void SonrakiZincir(Chain nextchain)
        {
            this.nextchain = nextchain;
        }
    }
}
