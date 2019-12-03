using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İtaratör_ornek
{
    interface Iterable
    {
        Iterator getIterator();
    }
    public interface Iterator
    {
        bool Next();
        object getItem();
    }

    public class ArrayIterator : Iterator
    {
        private LiseOgrenci ogr = new LiseOgrenci();
        private int index = 0;

        public bool Next()
        {
            return index < ogr.getOgrenci().Length;
        }
        public object getItem()
        {
            return ogr.getOgrenci()[index++];
        }


    }
    public class listIterator : Iterator
    {
        private UniversiteOgrenci uni = new UniversiteOgrenci();
        private int index = 0;
        public bool Next()
        {
            return index < uni.getOgrenci().Count();
        }
        public object getItem()
        {
            return uni.getOgrenci()[index++];
        }

    }




}
