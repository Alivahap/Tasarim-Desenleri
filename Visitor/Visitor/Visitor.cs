using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface Visitor
    {
       void visit(Cay cay);

        void visit(Su su);

     
        void visit(Et et);
    }
    class yıl_2018 : Visitor
    {
       


       public void visit(Cay cay)
        {
            Console.WriteLine("Çay vergi ücreti 2018");
        }

        public void visit(Su su)
        {
            Console.WriteLine("su vergi ücreti 2018");
        }

        public void visit(Et et)
        {
            Console.WriteLine("et vergi ücreti 2018");
        }
    }











}
