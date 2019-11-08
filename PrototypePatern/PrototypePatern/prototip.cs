using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatern
{
    public class prototip :ICloneable
    {
        string kitapad;
        string tür;
 string fiyat;

        public string Kitapad
        {
            get
            {
                return kitapad;
            }
            set
            {
                kitapad = value;
            }



        }
        public string Tür
        {
            get
            {
                return tür;
            }
            set
            {
                tür = value;
            }



        }

        public string Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                fiyat = value;
            }



        }



        public prototip()
        {

           



        }

      











        public object Clone()
        {

            return this.MemberwiseClone();
        }











    }
    




}
