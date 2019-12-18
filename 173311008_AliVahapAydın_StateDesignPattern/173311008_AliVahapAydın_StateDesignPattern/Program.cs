using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _173311008_AliVahapAydın_StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            OtomatContext context = new OtomatContext();
            //calış tuşuna basma
            context.baslat();

            context.baslat();
            context.Durdur();
            context.Durdur();
            context.baslat();
            Console.ReadLine();

        }
    }
}
