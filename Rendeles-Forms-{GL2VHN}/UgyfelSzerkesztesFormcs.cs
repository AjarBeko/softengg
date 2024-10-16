using Rendeles_Forms__GL2VHN_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles_Forms__GL2VHN_
{
    public partial class UgyfelSzerkesztesFormcs : Form
    {
        public Ugyfel SzerkesztettÜgyfél { get; set; }

        public UgyfelSzerkesztesFormcs(Ugyfel ugyfel)
        {
            InitializeComponent();
            this.SzerkesztettÜgyfél = ugyfel;
            ugyfelBindingSource.DataSource = SzerkesztettÜgyfél;
        }

        public UgyfelSzerkesztesFormcs()
        {
            InitializeComponent();
            this.SzerkesztettÜgyfél = new Ugyfel();
            ugyfelBindingSource.DataSource = SzerkesztettÜgyfél;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ugyfelBindingSource.EndEdit();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxMail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!rgxMail.IsMatch(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Rossz Email formátum, Tartalmaznia kell egy @ jelet, előtte és utána karakterekkel.\r\nA @ jel után legalább egy pontnak kell lennie, ami nem közvetlenül a @ jel után áll.");
                e.Cancel = true;
            }
            else
            {
                //Ha nincs hiba, eltüntetjük a hibaüzenetet
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxPhone = new Regex(@"^\+36(20|30|31|50|70)\d{7}$");
            if (!rgxPhone.IsMatch(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Magyar mobilszám formátumnak kell megfelelnie.\r\n+36-tal kell kezdődnie.\r\nEzt követően 20, 30, 31, 50 vagy 70 előhívó egyikével kell folytatódnia.\r\nVégül 7 számjegynek kell következnie.");
                e.Cancel = true;
            }
            else
            {
                //Ha nincs hiba, eltüntetjük a hibaüzenetet
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void tbNev_Validating(object sender, CancelEventArgs e)
        {
            Regex rgxNev = new Regex(@"^[\p{L} .'-]+$");

            if (!rgxNev.IsMatch(tbNev.Text))
            {
                errorProvider1.SetError(tbNev, "A név csak kis- és nagybetűket jeleníthet meg.");
                e.Cancel = true;
            }
            else
            {
                //Ha nincs hiba, eltüntetjük a hibaüzenetet
                errorProvider1.SetError(tbNev, "");
            }
        }
    }
}

