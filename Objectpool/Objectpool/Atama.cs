using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectpool
{
    class Atama// nesne açma kapama işlemleri 
    {
        private string atamastring;
        private Havuz_yönetici havuz_yönet;
        private atama_icerik atamai;

        public string Atama_string { get; set; }

        public Atama(string atamastring)
        {
            this.atamastring = atamastring;

        }
       



        //bakanlık atamaya onay verir 
        public void atama_onay()
        {
            havuz_yönet = Havuz_yönetici.Havuzyarat();
            atamai = havuz_yönet.Atama_yap(this.Atama_string);
           //singeleton tasarım deseni
                if (atamai != null)
                {
                    atamai.Ac();
                }           
                
           
            
          



        }
        public void atama_sonlandır()
        {
            havuz_yönet.atama_iptal(atamai);
            atamai.Kapa();

        }
        public void atama_yap(string ad)
        {
            atamai.atanan(ad);
        }


    }//
    class atama_icerik//nesnein meşgul mü 
    {
        private bool aktifmi;
        public bool Aktifmi {
            get
            {
                return aktifmi;
            }
            set
            {
                aktifmi = value;
            }

        }

        public atama_icerik()
        {
            aktifmi = false;
            
        }

        public string Ac()
        {
            return "atama işlemi açıldı";
        }

        public string Kapa()
        {
            return "atama işlemi kapatıldı";
        }
        public string atanan(string Adı)
        {
            return Adı;
        }



    }//
    class Havuz_yönetici
    {
        private const int Havuz_genislik = 2;
        protected static Havuz_yönetici n1;
        //bu yapıyı bilmiyorum

        private Dictionary<string, List<atama_icerik>> pools;

        protected Havuz_yönetici()
        {
            pools = new Dictionary<string, List<atama_icerik>>(Havuz_genislik);
        }
        
        public static Havuz_yönetici Havuzyarat()
        {
            if (n1 == null)
            {
                n1 = new Havuz_yönetici();
            }
            return n1;


        }
        public atama_icerik Atama_yap(string key)
        {
            if (pools.ContainsKey(key))
            {
                List<atama_icerik> nesneler=(List<atama_icerik>)pools[key];
                foreach(atama_icerik n1 in nesneler)
                {
                    if (!n1.Aktifmi)
                    {
                        return n1;
                    }

                }



            }
            else
            {
                List<atama_icerik> yeni_havuz = new List<atama_icerik>(Havuz_genislik);

                for(int i = 0; i <= Havuz_genislik - 1; i++)
                {
                    yeni_havuz.Add(new atama_icerik());
                }
                pools.Add(key, yeni_havuz);
                

                atama_icerik a1 = yeni_havuz[0];
                a1.Aktifmi = true;

                return a1;
            }

            return null;
        }
        public void atama_iptal(atama_icerik atama)
        {
            atama.Aktifmi = false;
        }





    }//nesne havuzu sınıfı 
}
