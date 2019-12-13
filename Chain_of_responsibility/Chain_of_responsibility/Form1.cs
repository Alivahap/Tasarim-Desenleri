using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chain_of_responsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Chain c1 = new toplama();
            Chain c2 = new Cikartma1();
            Chain c3 = new carpma();

            c1.SonrakiZincir(c2);
            c2.SonrakiZincir(c3);
            Sayilar istek = new Sayilar(10, 5, "topla");
            
            




        }
    }
}
