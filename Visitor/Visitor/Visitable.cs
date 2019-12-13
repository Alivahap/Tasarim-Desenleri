using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface Visitable
    {
        void Kabulet(Visitor visitor);

    }


    class Cay : Visitable
    {
        public void Kabulet(Visitor visitor)
        {
             visitor.visit(this);
        }
    }

    class Su : Visitable
    {
        public void Kabulet(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
    class Et : Visitable
    {
        public void Kabulet(Visitor visitor)
        {
            visitor.visit(this);
        }
    }








}
