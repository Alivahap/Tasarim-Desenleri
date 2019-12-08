using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_ornek
{
    interface IObserver
    {
        void Register(Kontrol k);
        void Unregister(Kontrol k);
        void Notify();

    }
}

 
     







