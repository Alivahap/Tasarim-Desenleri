using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Design_patern
{
    class Kumanda
    {
        public static ElektronikCihaz GetElektronik()
        {
            return new Televizyon();
        }


    }
}
