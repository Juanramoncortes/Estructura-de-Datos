using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dado Dad = new Dado();
        private void btnLanzar_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 100; a++)
            Dad.Lanzar();
            txtDatos.Text = Dad.ToString();
            Dad.clear();
        }

        private void btnLanzar2_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 100; a++)
            {
                Dad.Ran2();
                Dad.Lanzar2();
            }
            txtDatos.Text = Dad.toStringVelores();
            Dad.clear();
        }

        private void btnlan3_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 100; a++)
            {
                Dad.Ran3();
                Dad.Lanzar2();
            }
            txtDatos.Text = Dad.toStringVelores();
            Dad.clear();
        }
    }
}
