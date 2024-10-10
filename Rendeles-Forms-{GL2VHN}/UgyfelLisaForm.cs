using Microsoft.EntityFrameworkCore;
using Rendeles_Forms__GL2VHN_.Data;
using Rendeles_Forms__GL2VHN_.Models;
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
    public partial class UgyfelLisaForm : Form
    {
        private RendelesDbContext _context;
        private BindingList<Ugyfel> ugyfelBindingList;
        public UgyfelLisaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            _context.Ugyfel.Load();
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            ugyfelBindingSource.DataSource = ugyfelBindingList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterString = textBox1.Text.ToLower();
            ugyfelBindingSource.DataSource = from u in ugyfelBindingList
                                             where u.Nev.ToLower().Contains(filterString) ||
                                             u.Email.ToLower().Contains(filterString) ||
                                             (u.Telefonszam != null && u.Telefonszam.Contains(filterString))
                                             orderby u.UgyfelId
                                             select u;
        }

        private void ujugyfel_Click(object sender, EventArgs e)
        {
            UgyfelSzerkesztesFormcs ujUgyfelForm = new UgyfelSzerkesztesFormcs();
            if (ujUgyfelForm.ShowDialog() == DialogResult.OK)
            {
                ugyfelBindingList.Add(ujUgyfelForm.SzerkesztettÜgyfél);
                Mentés();
            }
        }
        void Mentés()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ugyfelmodosit_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current is Ugyfel kivalasztottUgyfel)
            {
                var eredetiUgyfel = new Ugyfel
                {
                    UgyfelId = kivalasztottUgyfel.UgyfelId,
                    Nev = kivalasztottUgyfel.Nev,
                    Lakcim = kivalasztottUgyfel.Lakcim,
                    Telefonszam = kivalasztottUgyfel.Telefonszam,
                };

                using (var szerkesztesForm = new UgyfelSzerkesztesFormcs(kivalasztottUgyfel))
                {
                    if (szerkesztesForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            _context.SaveChanges(); 
                            MessageBox.Show("Az ügyfél adatai sikeresen frissítve lettek.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hiba történt a mentés során: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        _context.Entry(kivalasztottUgyfel).CurrentValues.SetValues(eredetiUgyfel);
                        _context.Ugyfel.Load(); 
                        ugyfelBindingSource.ResetBindings(false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott ügyfél.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ugyfeltorol_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current != null)
            {
                var result = MessageBox.Show("Biztosan törölni szeretné az ügyfelet?", "Törlés megerősítése",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ugyfelBindingSource.RemoveCurrent();
                    Mentés();
                    MessageBox.Show("Sikeres törlés!", "Sikeres",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon ki egy ügyfelet a törléshez.", "Nincs kiválasztott ügyfél",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
