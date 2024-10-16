using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles_Forms__GL2VHN_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TermekKategoriaForm termekKategoriaForm = new TermekKategoriaForm();
            termekKategoriaForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UgyfelForm ugyfelForm = new UgyfelForm();
            ugyfelForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UgyfelLisaForm ugyfelLisaForm = new UgyfelLisaForm();
            ugyfelLisaForm.ShowDialog();
        }

        private void rendeles_Click(object sender, EventArgs e)
        {
            RendelesForm ren = new RendelesForm();
            ren.ShowDialog();
        }
    }
}
