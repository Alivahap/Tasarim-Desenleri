using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace observer_ornek
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {



            InitializeComponent();
              void goster(Kontrol k)
            {
                label1.Text += (k.isim + " " + k.text+ "\n");

            }

            Kontrol k1 = new KanalSahibi();
            k1.isim = "Ali";

            Kontrol k2 = new KanalSahibi();
            k2.isim = "mehmet";


            Kanalislem ab = new Kanalislem();
            ab.Register(k1);
            ab.Register(k2);

            ab.Notify();
            goster(k1);
            goster(k2);

            ab.AboneCıkar();
            ab.Notify();
            goster(k1);
            goster(k2);

            ab.AboneCıkar();
            ab.Notify();
            goster(k1);
            goster(k2);




        }
    }
}
