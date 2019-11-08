using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePatern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //bir kitap mağazası hangi kitapların alındığı kaydedilsin istiyor  fakat her ihtimale karşı
            //bir sorun cıkarsa o verilerin kurtarılmasını istiyor 

            


        }
        prototip p1;
        prototip p2;

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = new prototip();

           p1.Kitapad= textBox1.Text;
            p1.Tür = textBox2.Text;
            p1.Fiyat = textBox3.Text;

         

        }

        private void button2_Click(object sender, EventArgs e)
        {


             p2 = (prototip)p1.Clone();

           label7.Text=  p2.Kitapad;

            label8.Text = p2.Tür;

            label9.Text = p2.Fiyat;
            



        }
    }
}
