using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Design_patern
{
    interface Command
    {
        void execude();
    }
     class Televizyon_Ac : Command
    {
        ElektronikCihaz cihaz;
        public  Televizyon_Ac(ElektronikCihaz _cihaz)
        {
            cihaz = _cihaz;

        }




        public void execude()
        {
            cihaz.on();   
        }
    }
    class Televizyon_kapa
    {
        ElektronikCihaz cihaz;
        Televizyon_kapa(ElektronikCihaz _cihaz)
        {
            cihaz = _cihaz;

        }




        public void execude()
        {
            cihaz.on();
        }


    }




}
