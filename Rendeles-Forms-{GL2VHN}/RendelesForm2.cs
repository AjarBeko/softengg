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
    public partial class RendelesFrom2 : Form
    {
        private readonly RendelesDbContext _context;
        private BindingSource cimEgybenDTOBindingSource = new BindingSource();
        public RendelesFrom2()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadCimek();
            //LoadUgyfelek();
            LoadRendelesek();
            LoadRendelesTetel();
            LoadTermekek();

        }

        //Ugyfelek betöltése, szűrése
        private void RendelesFrom2_Load(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }

        private void LoadUgyfelek()
        {
            var q = from i in _context.Ugyfel
                    where i.Nev.Contains(ugyfelszures_textbox.Text) || i.Email.Contains(ugyfelszures_textbox.Text)
                    orderby i.Nev
                    select i;

            ugyfelBindingSource.DataSource = q.ToList();
            ugyfelBindingSource.ResetCurrentItem();
        }

        private void ugyfelszures_textbox_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }

        //címek betöltése comboboxba
        private void LoadCimek()
        {
            var q = from i in _context.Cim
                    select new CimEgybenDTO
                    {
                        CimId = i.CimId,
                        CimEgyben = $"{i.Iranyitoszam}-{i.Varos}, {i.Orszag}: {i.Utca}, {i.Hazszam}"
                    };
            cimEgybenDTOBindingSource.DataSource = q.ToList();
            cimEgybenDTOBindingSource.ResetCurrentItem();
            //var cimekList = q.ToList();
            //cimEgybenDTOBindingSource.DataSource = cimekList;
        }
        /*
        private void cim_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadCimek();
        }*/

        //rendelések betöltése
        private void LoadRendelesek()
        {
            if (ugyfelBindingSource.Current == null) return;
            dataGridView1.DataSource = null;
            var rendeles = from i in _context.Rendeles
                           where i.UgyfelId == ((Ugyfel)ugyfelBindingSource.Current).UgyfelId
                           select i;
            rendelesBindingSource.DataSource = rendeles.ToList();
            rendelesek_listbox.DataSource = rendelesBindingSource;

            if (rendelesek_listbox.Items.Count > 0)
            {
                rendelesek_listbox.SelectedIndex = 0;
            }

            rendelesBindingSource.ResetCurrentItem();
        }
        private void ugyelek_listbox_SelectedIndexChanged(object sender, EventArgs e)
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
        private void rendelesek_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesTetel();
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

        //új rendelés
        private void ujrendeles_button_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current == null) return;

            var cim = ((Ugyfel)ugyfelBindingSource.Current).Lakcim ?? _context.Cim.FirstOrDefault();

            if (cim == null)
            {
                MessageBox.Show("Nincs cím megadva");
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

            rendelesek_listbox.Text = $"A rendelés teljes értéke: {ujRendeles.Vegosszeg} Ft";

            LoadRendelesek();

            rendelesek_listbox.SelectedItem = ujRendeles;
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

        //Tétel hozzáadása

        private const decimal AFA = .27m;
        private void tetelhozzaad_button_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(mennyiseg_textbox.Text, out int mennyiseg) || mennyiseg <= 0)
            {
                MessageBox.Show("Rossz mennyiség!");
                return;
            }
            if (rendelesBindingSource.Current == null || termekBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kiválasztva rendelés vagy termék!");
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
        private void teteltorles_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nincs kiválasztott tétel!");
                return;
            }

            var selectedTetel = dataGridView1.SelectedRows[0].DataBoundItem as RendelesTetelDTO;

            var tetel = (from i in _context.RendelesTetel
                         where i.TetelId == selectedTetel!.TetelId
                         select i).FirstOrDefault();

            if (tetel != null)
            {
                _context.RendelesTetel.Remove(tetel);
                Mentés();

                LoadRendelesTetel();
            }
        }

        //végösszegszámítás

        private void UpdateVegosszeg()
        {
            if (rendelesBindingSource.Current == null) return;

            var kivalasztottRendeles = (Rendeles)rendelesBindingSource.Current;

            var vegosszeg = _context.RendelesTetel
                .Where(i => i.RendelesId == kivalasztottRendeles.RendelesId)
                .Sum(i => i.Mennyiseg * i.BruttoAr);

            kivalasztottRendeles.Vegosszeg = vegosszeg * (1 - kivalasztottRendeles.Kedvezmeny);

            Mentés();
            //rendelesBindingSource.ResetBindings(false); !!!!!ezzel nem fut!!!!!
        }





        //cimek összefűzése
        public class CimEgybenDTO
        {
            public int CimId { get; set; }
            public string? CimEgyben { get; set; }
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


    }
}
