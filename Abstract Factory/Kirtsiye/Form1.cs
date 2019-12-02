using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirtsiye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //kırtasiye seçimine göre kırtasiye özeliklerini gönderen sınıf tasarımı 
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Merkez kırtasiye")
            {
                kirtasiye_factory f=Fabrika_Nesne.GetKirtasiye("Merkez kırtasiye");
                Merkez_kirtasiye m = new Merkez_kirtasiye();
                label2.Text=m.defterler()+""+m.kalemler();


            }
            else if(comboBox1.Text== "Mahale kırtasiye")
            {
                kirtasiye_factory f = Fabrika_Nesne.GetKirtasiye("Merkez kırtasiye");
                Mahale_kirtasiye m = new Mahale_kirtasiye();
                label2.Text = m.defterler() + "" + m.kalemler();





            }

        }
    }
}
