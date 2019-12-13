using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public class Sayilar
    {
        private int sayi1;
        private int sayi2;

        private String islemtürü;

        public Sayilar(int sayi1,int sayi2,string islemtürü)
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
            this.islemtürü = islemtürü;

        }
        public int Sayi1
        {
            get
            {
                return sayi1;
            }
        }
        public int Sayi2
        {
            get
            {
                return sayi2;
            }
        }
         public String Islemtürü
        {
            get
            {
                return islemtürü;
            }
        }


    }
}
