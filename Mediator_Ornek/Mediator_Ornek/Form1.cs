using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Katılımcı k1 = new NormalKatılımcı("Ali");
            Katılımcı k2 = new NormalKatılımcı("Ahmet");
            Katılımcı k3 = new NormalKatılımcı("Ayse");

            SohbetOdası s_oda = new SohbetOdası();
            s_oda.katilimciEkle(k1);
            s_oda.katilimciEkle(k2);
            s_oda.katilimciEkle(k3);


            s_oda.MesajGonder(k1, k2, "naber kanka");
            label1.Text+=k2.mesaj;

            s_oda.MesajGonder(k2, k1, "iyidir senden");
            label1.Text += k1.mesaj;


            s_oda.BroadcastMesajGonder(k1, "Merhaba");
            label1.Text += k1.mesaj + "" + k2.mesaj + "" + k3.mesaj;      





        }
    }
}
