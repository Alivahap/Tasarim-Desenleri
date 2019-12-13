using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            yıl_2018 y1 = new yıl_2018();
            yıl_2019 y2 = new yıl_2019();

            Su s1 = new Su();
            Cay c1 = new Cay();
            Et e1 = new Et();

            s1.Kabulet(y1);
            c1.Kabulet(y1);
            e1.Kabulet(y1);

            
            Console.WriteLine("----------------------------------------------");

            s1.Kabulet(y2);
            c1.Kabulet(y2);
            e1.Kabulet(y2);

            Console.ReadLine();



        }
    }
}
