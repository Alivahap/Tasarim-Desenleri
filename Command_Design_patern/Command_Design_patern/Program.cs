using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Design_patern
{
    class Program
    {
        static void Main(string[] args)
        {
            ElektronikCihaz kumanda = Kumanda.GetElektronik();

            Televizyon_Ac emir = new Televizyon_Ac(kumanda);

            CihazButton eylem = new CihazButton(emir);

            eylem.Bas();

            Console.ReadLine();
















        }
    }
}
