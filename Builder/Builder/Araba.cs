using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Araba
    {
        public static void yapıcı(Arabayapıcı yap ,string[] parcalar)
        {

            foreach(string p in parcalar)
            {
                yap.Parca_yap(p);
            }


        }


    
        
    }

    public abstract class Arabayapıcı
    {
        public abstract void Parca_yap(string parca_adı);
        public abstract Urun get_Urun();

     
    }
    public class Araba1_Ozellik : Arabayapıcı
    {
        private Urun urun = new Urun();
        public override void Parca_yap(string parca_adı)
        {
            urun.ekle(parca_adı);
        }
        public override Urun get_Urun()
        {
            return urun;
        }



    }
    public class Araba2_Ozellik : Arabayapıcı
    {
        private Urun urun = new Urun();
        public override void Parca_yap(string parca_adı)
        {
            urun.ekle(parca_adı);
        }
        public override Urun get_Urun()
        {
            return urun;
        }



    }








    public class Urun
    {
        private List<string> araba_parca = new List<string>();

        public void ekle(string parca_adı)
        {
            araba_parca.Add(parca_adı);
        }
        public override string ToString()
        {
            string parcalar="";
            foreach(string parca in araba_parca)
            {
                parcalar += parca + " ";
            }
            return parcalar;
        }

    }


}
