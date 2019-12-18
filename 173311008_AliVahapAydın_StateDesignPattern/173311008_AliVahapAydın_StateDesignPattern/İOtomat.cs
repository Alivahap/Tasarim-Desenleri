using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _173311008_AliVahapAydın_StateDesignPattern
{
    interface İOtomat
    {
        void Baslama(OtomatContext context);
        void Durma(OtomatContext context);
       

    }
    class Calısma : İOtomat
    {
        public void Baslama(OtomatContext context)
        {
            Console.WriteLine("Otomat makinesi çalışır durumdadır");
        }

        public void Durma(OtomatContext context)
        {
            context.Durum = new Durdurma();
            Console.WriteLine("çalışma durduruldu");

        }
    }


    class Durdurma : İOtomat
    {
        public void Baslama(OtomatContext context)
        {
            Console.WriteLine("Otomat makinesi çalışıyor");
            context.Durum = new Calısma();
        }

    
        void İOtomat.Durma(OtomatContext context)
        {
            Console.WriteLine("Makine zaten durma halinde");
           


        }
    }


 




}
