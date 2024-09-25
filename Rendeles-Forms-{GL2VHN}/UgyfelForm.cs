using Rendeles_Forms__GL2VHN_.Data;
using Rendeles_Forms__GL2VHN_.Models;

namespace Rendeles_Forms__GL2VHN_
{
    public partial class UgyfelForm : Form
    {
        private RendelesDbContext _context;
        public UgyfelForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadData();
        }
        private void LoadData()
        {
            ugyfelBindingSource.DataSource = _context.Ugyfel.ToList();
        }

        private void buttonnew_Click(object sender, EventArgs e)
        {
            try
            {
                var ujUgyfel = new Ugyfel { Nev = "Új Ügyfél", Email = "uj@pelda.com" };
                _context.Ugyfel.Add(ujUgyfel);
                _context.SaveChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
               
            }
            
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            LoadData();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var torlendoUgyfel = dataGridView1.CurrentRow.DataBoundItem as Ugyfel;
                if (torlendoUgyfel != null)
                {
                    _context.Ugyfel.Remove(torlendoUgyfel);
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void buttonupg_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}