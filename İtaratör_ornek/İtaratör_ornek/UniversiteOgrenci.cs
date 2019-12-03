using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İtaratör_ornek
{
    class UniversiteOgrenci:Iterable
    {
        List<Ogrenci> ogr;
        public UniversiteOgrenci()
        {
            ogr = new List<Ogrenci>();

            ogr.Add(new Ogrenci(4, "ali vahap", "aydın"));

            ogr.Add(new Ogrenci(5, "ayşe", "apaydın"));

            ogr.Add(new Ogrenci(6, "fatma", "zorlu"));

        }


        public Iterator getIterator()
        {
            return new listIterator();
        }

        public List<Ogrenci> getOgrenci()
        {


            return ogr;
        }


    }
}
