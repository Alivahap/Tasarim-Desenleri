using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İtaratör_ornek
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            LiseOgrenci l1 = new LiseOgrenci();
            yazdir(l1.getIterator());

            UniversiteOgrenci u1 = new UniversiteOgrenci();
            yazdir(u1.getIterator());



            void yazdir(Iterator itr)
            {
                while (itr.Next())
                    label1.Text +=" "+itr.getItem().ToString()+"\n";
            }





        }










        //public interface Iterator
        //{
        //    bool Next();
        //    object getItem();
        //}

        //public interface Iterable
        //{
        //    Iterator getIterator();
        //}

        //public class ArrayIterator : Iterator
        //{
        //    private LiseOgrenci ogr = new LiseOgrenci();
        //    private int index = 0;

        //    public bool Next()
        //    {
        //        return index < ogr.getOgrenci().Length;
        //    }
        //    public object getItem()
        //    {
        //        return ogr.getOgrenci()[index++];
        //    }


        //}
        //public class listIterator : Iterator
        //{
        //    private UniversiteOgrenci uni = new UniversiteOgrenci();
        //    private int index = 0;
        //    public bool Next()
        //    {
        //        return index < uni.getOgrenci().Count();
        //    }
        //    public object getItem()
        //    {
        //        return uni.getOgrenci()[index++];
        //    }

        //}
    }
}





