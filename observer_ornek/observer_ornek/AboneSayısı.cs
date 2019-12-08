using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_ornek
{
    class Kanalislem : IObserver
    {
        public int abonesayı;
        public List<Kontrol> kontoller;


        public Kanalislem()
        {
            kontoller = new List<Kontrol>();
            abonesayı = 10;

        }
        public void AboneCıkar()
        {
            --abonesayı;
        }

        public void Notify()
        {
            for (int i = 0; i <= kontoller.Count - 1; i++)
            {
                kontoller[i].OnAction(abonesayı.ToString());
            }

        }

        void IObserver.Notify()
        {
            throw new NotImplementedException();
        }

           public void Register(Kontrol k)
        {
            kontoller.Add(k);
        }

        void IObserver.Register(Kontrol k)
        {
            throw new NotImplementedException();
        }

       public void Unregister(Kontrol k)
        {
            kontoller.Remove(k);
        }

        void IObserver.Unregister(Kontrol k)
        {
            throw new NotImplementedException();
        }
    }
}

