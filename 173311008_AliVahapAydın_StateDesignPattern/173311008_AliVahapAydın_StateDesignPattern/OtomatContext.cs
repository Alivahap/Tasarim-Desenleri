using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _173311008_AliVahapAydın_StateDesignPattern
{
    class OtomatContext
    {
        private İOtomat durum;
        public İOtomat Durum
        {
            get
            {
                return durum;
            }
            set
            {
                durum = value;
            }

        }

        public OtomatContext()
        {
            Console.WriteLine("otomat dolabı açıldı ve duragan modda şuan");
            durum = new Durdurma();

        }
        public void baslat()
        {
            durum.Baslama(this);
        }

        public void Durdur()
        {
            durum.Durma(this);

        }









    }
}
