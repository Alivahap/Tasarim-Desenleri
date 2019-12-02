using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string[] araba1_özelik = { textBox1.Text, textBox2.Text };
            string[] araba2_özelik = { textBox3.Text, textBox4.Text };
            Arabayapıcı araba = new Araba1_Ozellik();
            Araba.yapıcı(araba, araba1_özelik);
            Urun urun = araba.get_Urun();
            label_araba1.Text = urun.ToString();

            //----------------------- araba2 özellik
            Arabayapıcı araba2 = new Araba2_Ozellik();
            Araba.yapıcı(araba2,araba2_özelik);
            Urun urun2 = araba2.get_Urun();
            label_araba2.Text = urun2.ToString();


        }
    }
}
