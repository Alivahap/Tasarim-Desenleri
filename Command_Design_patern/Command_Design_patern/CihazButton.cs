using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Design_patern
{
    class CihazButton
    {
        Command command;
        public CihazButton(Command yeni_command)
        {
            command = yeni_command;
        }

        public void Bas()
        {
            command.execude();
        }



    }
}
