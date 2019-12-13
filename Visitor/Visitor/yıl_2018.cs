using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class yıl_2019:Visitor
    {
        public void visit()
        {
           
        }
        public void visit(Cay cay)
        {
            Console.WriteLine("Çay vergi ücreti 2019  ");
        }

        public void visit(Su su)
        {
            Console.WriteLine("su vergi ücreti 2019");
        }

        public void visit(Et et)
        {
            Console.WriteLine("et vergi ücreti 2019");
        }
    }
}
