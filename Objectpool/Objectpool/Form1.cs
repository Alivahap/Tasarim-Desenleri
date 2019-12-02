using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objectpool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atama atama_islem = new Atama("A1");
            atama_icerik icerik = new atama_icerik();
            // yapılan atamaları göstermek için içreik sınıfını tanımladım
            atama_islem.atama_onay();
            label1.Text += icerik.Ac()+"\n";

            atama_islem.atama_yap("Ali Vahap AYDIN");
            label1.Text += icerik.atanan("Ali Vahap AYDIN \n");

            atama_islem.atama_sonlandır();
            label1.Text += icerik.Kapa();


        }

        //bir hastanenin doktorları olsun ve bu doktorlar işten gecici süre ile ayrılırsa veya hastane yoğunluğu fazlaysa 
        //onun yerine sağlık bakanlığı tarafından gecici bir doktor atanması işlemi gerçekleşsin 





    }
}
