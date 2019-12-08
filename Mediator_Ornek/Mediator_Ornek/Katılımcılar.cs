using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Ornek
{
   abstract class Katılımcı
    {
        private string nick;
        public string mesaj;
        public string Nick { get; set; }
        protected Katılımcı(String _nick)
        {
            this.nick = _nick;
        }

        public abstract void MesajAl(Katılımcı gonderen, string mesaj);


    }
    class NormalKatılımcı : Katılımcı
    {
        public NormalKatılımcı(string nick):base(nick)
        {

        }

        
        public override void MesajAl(Katılımcı gonderen, string mesaj)
        {

            this.mesaj = gonderen.Nick + "----->" + this.Nick + mesaj + "\n";

        }


    }
    class yonetici : Katılımcı
    {
        public yonetici(string nick) : base(nick)
        {

        }

       
        public override void MesajAl(Katılımcı gonderen, string mesaj)
        {

            this.mesaj = gonderen.Nick + "----->" + this.Nick + mesaj+"\n";

        }




    }








}
