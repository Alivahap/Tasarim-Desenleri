using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethodu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Hız")
            {
                Lamborcini l1 = new Lamborcini();
                label2.Text = l1.ArabaModel()+", hız "+l1.hız+"Fiyat "+l1.fiyat;

            }
        
            else if(comboBox1.Text== "Dayanıklılık")
            {
                Volvo v1 = new Volvo();
             label2.Text= v1.ArabaModel()+",Dayanıklılık "+v1.dayanıklık;


            }
            else if(comboBox1.Text == "Yanlama")
            {
                Tofas t1 = new Tofas();

                label2.Text = t1.ArabaModel() +", "+ t1.özelikler;

            }
            else if (comboBox1.Text == "Yakıt Tüketimi")
            {
                Renault r1 = new Renault();
                label2.Text = r1.ArabaModel() + r1.yakıttüketimi;

            }




        }


    }
}
