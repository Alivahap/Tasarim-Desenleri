using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İtaratör_ornek
{
    class Ogrenci
    {
        private int ogrno;
        private string ad;
        private string soyad;


        public Ogrenci(int _ogrno,string _ad,string _soyad){
            ogrno = _ogrno;
            ad = _ad;
            soyad = _soyad;

            }
        public override string ToString()
        {

            return " " + ogrno + " " + ad + " " + soyad;     
        }
        



    }
}
