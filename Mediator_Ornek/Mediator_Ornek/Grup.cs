using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Ornek
{
    abstract class Grup
    {
        protected List<Katılımcı> katılımcılar;
        protected Grup()
        {
            katılımcılar = new List<Katılımcı>();
        }
        public void katilimciEkle(Katılımcı k)
        {
            if (katılımcılar.Contains(k) == false)
            {
                katılımcılar.Add(k);
            }



        }
        public abstract void MesajGonder(Katılımcı gonderen, Katılımcı alan, string mesaj);
        public abstract void BroadcastMesajGonder(Katılımcı gonderen, string mesaj);
        



    }
}
