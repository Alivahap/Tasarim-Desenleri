using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPaterni
{
    class Singleton
    {
        private static Singleton nesne;
        private string AD,SOYAD;


        protected Singleton()


        {

        }

        public static Singleton NesneOlustur()
        {
            if (nesne == null) {

                nesne = new Singleton();

            }

            return nesne;
        }
        public string Get_Ad()
        {
            return AD;
        }
        public void Set_Ad(string deger)
        {
            AD = deger;

        }

        public string Get_Soyad()
        {
            return SOYAD;
        }
        public void Set_Soyad(string deger)
        {
            SOYAD = deger;

        }






    }
}
