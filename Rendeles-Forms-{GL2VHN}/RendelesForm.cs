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
    public partial class RendelesForm : Form
    {
        private readonly RendelesDbContext _context;
        private BindingSource cimEgybenDTOBindingSource = new BindingSource();
        public RendelesForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadCimek();
            LoadRendelesTetel();
            LoadTermekek();
            LoadRendelesek();
        }

        //Ugyfelek betöltése, szűrése
        private void RendelesForm_Load(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }
        private void LoadUgyfelek()
        {
            var q = from x in _context.Ugyfel
                    where x.Nev.Contains(ugyfelszur.Text) || x.Email.Contains(ugyfelszur.Text)
                    orderby x.Nev
                    select x;

            ugyfelBindingSource.DataSource = q.ToList();
            ugyfelBindingSource.ResetCurrentItem();
        }

        private void ugyfelszur_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }

        //termékek betöltése
        private void LoadTermekek()
        {
            var t = from x in _context.Termek
                    orderby x.Nev
                    select x;
            termekBindingSource.DataSource = t.ToList();
            termekBindingSource.ResetCurrentItem();
        }

        //címek betöltése comboboxba
        private void LoadCimek()
        {
            var q = from x in _context.Cim
                    select new CimEgybenDTO
                    {
                        CimId = x.CimId,
                        CimEgyben = $"{x.Iranyitoszam}-{x.Varos}, {x.Orszag}: {x.Utca} {x.Hazszam}"
                    };
            var cimekList = q.ToList();
            cimEgybenDTOBindingSource.DataSource = cimekList;

            rendelescime.DataSource = cimEgybenDTOBindingSource;
            rendelescime.DisplayMember = "CimEgyben";
            rendelescime.ValueMember = "CimId";

        }

        //rendelések betöltése
        private void LoadRendelesek()
        {
            if (ugyfelBindingSource.Current == null) return;
            dataGridView1.DataSource = null;
            var rendeles = from x in _context.Rendeles
                           where x.UgyfelId == ((Ugyfel)ugyfelBindingSource.Current).UgyfelId
                           select x;
            rendelesBindingSource.DataSource = rendeles.ToList();
            rendeleslist.DataSource = rendelesBindingSource;
            if (rendeleslist.Items.Count > 0)
            {
                rendeleslist.SelectedIndex = 0;
            }
            rendelesBindingSource.ResetCurrentItem();


        }

        private void ugyfellist_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesek();
        }

        //rendelések betöltése datagridview-ba

        private void LoadRendelesTetel()
        {
            if (rendelesBindingSource.Current == null) return;

            var q = from rt in _context.RendelesTetel
                    where rt.RendelesId == ((Rendeles)rendelesBindingSource.Current).RendelesId
                    select new RendelesTetelDTO
                    {
                        TetelId = rt.TetelId,
                        TermekNev = rt.Termek.Nev,
                        Mennyiseg = rt.Mennyiseg,
                        EgysegAr = rt.EgysegAr,
                        Afa = rt.Afa,
                        NettoAr = rt.NettoAr,
                        BruttoAr = rt.BruttoAr
                    };

            dataGridView1.DataSource = q.ToList();
            UpdateVegosszeg();
        }
        //végösszegszámítás
        private void UpdateVegosszeg()
        {
            if (rendelesBindingSource.Current == null) return;

            var kivalasztottRendeles = (Rendeles)rendelesBindingSource.Current;

            var vegosszeg = _context.RendelesTetel
                .Where(rt => rt.RendelesId == kivalasztottRendeles.RendelesId)
                .Sum(rt => rt.Mennyiseg * rt.BruttoAr);

            kivalasztottRendeles.Vegosszeg = vegosszeg * (1 - kivalasztottRendeles.Kedvezmeny);

            label10.Text = $"A rendelés teljes értéke: {kivalasztottRendeles.Vegosszeg} Ft";
            Mentés();
        }

        private void rendeleslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesTetel();
        }

        //új rendelés hozzáadása
        private void ujrendeles_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current == null)
            {
                return;
            }

            // Ha van beállítva az ügyfélhez alapértelmezett lakcím, akkor azt adja vissza, egyéb esetben a címek közül a legelsőt.
            var cim = ((Ugyfel)ugyfelBindingSource.Current).Lakcim ?? _context.Cim.FirstOrDefault();

            if (cim == null)
            {
                MessageBox.Show("Nincs cím megadva.");
                return;
            }

            var ujRendeles = new Rendeles()
            {
                UgyfelId = ((Ugyfel)ugyfelBindingSource.Current).UgyfelId,
                SzallitasiCimId = cim.CimId,
                RendelesDatum = DateTime.Now,
                Kedvezmeny = 0,
                Vegosszeg = 0,
                Statusz = "Feldolgozás alatt"
            };

            _context.Rendeles.Add(ujRendeles);
            Mentés();

            label10.Text = $"A rendelés teljes értéke: {ujRendeles.Vegosszeg} Ft";

            LoadRendelesek();

            rendeleslist.SelectedItem = ujRendeles;
        }

        private void Mentés()
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

        //tétel hozzáadása

        private const decimal AFA = .27m;
        private void tetelhozzaad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int mennyiseg) || mennyiseg <= 0)
            {
                MessageBox.Show("Rossz mennyiség!");
                return;
            }

            if (rendelesBindingSource.Current == null || termekBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kiválasztva rendelés vagy termék!");
                return;
            }

            var kivalasztottTermek = (Termek)termekBindingSource.Current;

            decimal bruttoAr = kivalasztottTermek.AktualisAr * (1 + AFA);

            var ujTetel = new RendelesTetel
            {
                RendelesId = ((Rendeles)rendelesBindingSource.Current).RendelesId,
                TermekId = kivalasztottTermek.TermekId,
                Mennyiseg = mennyiseg,
                EgysegAr = kivalasztottTermek.AktualisAr,
                Afa = AFA,
                NettoAr = kivalasztottTermek.AktualisAr * mennyiseg,
                BruttoAr = bruttoAr
            };

            _context.RendelesTetel.Add(ujTetel);
            Mentés();
            LoadRendelesTetel();
        }

        //tétel törlése
        private void teteltorol_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nincs kiválasztva tétel!");
                return;
            }

            var selectedTetel = dataGridView1.SelectedRows[0].DataBoundItem as RendelesTetelDTO;

            var tetel = (from rt in _context.RendelesTetel
                         where rt.TetelId == selectedTetel!.TetelId
                         select rt).FirstOrDefault();

            if (tetel != null)
            {
                _context.RendelesTetel.Remove(tetel);
                Mentés();

                LoadRendelesTetel();
            }
        }

        //rendelések betöltése datagridview-ba
        public class RendelesTetelDTO
        {
            public int TetelId { get; set; }
            public string? TermekNev { get; set; }
            public int Mennyiseg { get; set; }
            public decimal EgysegAr { get; set; }
            public decimal Afa { get; set; }
            public decimal NettoAr { get; set; }
            public decimal BruttoAr { get; set; }
        }

        //cimek összefűzése
        public class CimEgybenDTO
        {
            public int CimId { get; set; }
            public string? CimEgyben { get; set; }
        }
    }
}
