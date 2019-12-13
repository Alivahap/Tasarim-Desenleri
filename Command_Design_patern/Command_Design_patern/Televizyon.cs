using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Design_patern
{
    class Televizyon:ElektronikCihaz
    {
        public void off()
        {
            Console.WriteLine("kapandı");
        }

        public void on()
        {
            Console.WriteLine("acıldı");

        }


    }
    












}
