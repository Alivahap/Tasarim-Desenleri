using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_ornek
{
    abstract class Kontrol
    {
        public string text;
         public string isim;


        public abstract void OnAction(string s);

        public abstract void Add(IObserver o);
        public abstract void Remove(IObserver o);





    }

    class KanalSahibi : Kontrol
    {
        public override void Remove(IObserver o)
        {
           

            o.Unregister((Kontrol)o);
        }

        public override void Add(IObserver o)
        {
            o.Register((Kontrol)o);
        }

        public override void OnAction(string deger)
        {
            text = deger;
        }
    }



}
