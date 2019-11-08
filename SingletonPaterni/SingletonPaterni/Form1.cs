using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPaterni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Enabled = false;


        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if(comboBox1.Text== "10 -15 yıl arası")
            {
                if(comboBox2.Text== "Evet")
                {
                    button1.Enabled = true;
                }
            }
            else
            {
                button1.Enabled = false;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Singleton n1 = Singleton.NesneOlustur();
            n1.Set_Ad(textBox1.Text);


            n1.Set_Soyad(textBox2.Text);

          
        




        }

        private void button3_Click(object sender, EventArgs e)
        {

            Singleton n2 = Singleton.NesneOlustur();

            label5.Text = n2.Get_Ad()+n2.Get_Soyad();




        }







    }
}
