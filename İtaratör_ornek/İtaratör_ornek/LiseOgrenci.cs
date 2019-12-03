using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İtaratör_ornek
{
    class LiseOgrenci:Iterable
    {
        Ogrenci []ogr;

        public LiseOgrenci()
        {
            ogr = new Ogrenci[3];
            ogr[0] = new Ogrenci(1, "Mehmet", "Akpınar");
            ogr[1] = new Ogrenci(2, "Mehmet", "Dağpınar");
            ogr[2] = new Ogrenci(3, "Mustafa", "Akpınar");

        }

        public Iterator getIterator()
        {

            return new ArrayIterator();

        }

        public Ogrenci[] getOgrenci()
        {


            return ogr;
        }





    }
}
