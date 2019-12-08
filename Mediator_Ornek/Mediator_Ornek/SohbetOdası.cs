using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Ornek
{
    class SohbetOdası:Grup
    {
        public SohbetOdası() : base()
        {

        }
        public override void BroadcastMesajGonder(Katılımcı gonderen, string mesaj)
        {
            foreach(Katılımcı k in this.katılımcılar)
            {
                k.MesajAl(gonderen, mesaj);

            }

        }
        public override void MesajGonder(Katılımcı gonderen, Katılımcı alan, string mesaj)
        {
            alan.MesajAl(gonderen, mesaj);
        }




    }
}
