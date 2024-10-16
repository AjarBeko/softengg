using Rendeles_Forms__GL2VHN_.Data;
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
        }

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



        public class CimEgybenDTO
        {
            public int CimId { get; set; }
            public string? CimEgyben { get; set; }
        }

    }
}
