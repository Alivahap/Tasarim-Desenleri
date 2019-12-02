using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirtsiye
{
    class Fabrika_Nesne
    {
        public static kirtasiye_factory GetKirtasiye(string kirtasiye_isim)
        {

            if(kirtasiye_isim=="Merkez kırtasiye")
            {

                return new Merkez_kirtasiye();
            }

            if(kirtasiye_isim=="Mahale kırtasiye")
            {

                return new Mahale_kirtasiye();
            }

            throw new Exception("hata");
        }



    }
    public abstract class kirtasiye_factory
    {

        public abstract string kalemler();

        public abstract string defterler();


    }

   
    public class Mahale_kirtasiye : kirtasiye_factory
    {
        public override string defterler()
        {

            return "kareli defter, çizgili defter ";
        }

        public override string kalemler()
        {
            return "kurşun kalem,kırmızı kalem ";
        }
    }

    public class Merkez_kirtasiye : kirtasiye_factory
    {
        public override string defterler()
        {
            return "kareli defter, çizgili defter,telli çizgili defter,telli kareli defter ";
        }

        public override string kalemler()
        {
            return "kurşun kalem,kırmızı kalem ,0.5 uclu kalem,0.7 uclu kalem ";
        }
    }







}

