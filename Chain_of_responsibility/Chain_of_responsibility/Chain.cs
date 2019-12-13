using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
   public interface Chain
    {
        
        void SonrakiZincir(Chain nextchain);
       void Hesapla(Sayilar istek);


    }
}
