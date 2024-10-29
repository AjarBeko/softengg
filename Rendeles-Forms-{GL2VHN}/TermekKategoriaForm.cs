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
using System.Xml.Linq;

namespace Rendeles_Forms__GL2VHN_
{
    public partial class TermekKategoriaForm : Form
    {

        //RendelesDbContext _context = new RendelesDbContext();
        private RendelesDbContext _context;
        private bool isNewItem = false;
        private TermekKategoria newKategoria = null!;
        public TermekKategoriaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            /*TreeNode ujKat = new TreeNode("ÚJ");
            treeViewKategoriak.Nodes.Add(ujKat);

            TermekKategoria tk = new TermekKategoria();
            tk.Nev = ujKat.Text;
            tk.SzuloKategoria = null;
            _context.TermekKategoria.Add(tk);
            _context.SaveChanges();
            ujKat.Tag = tk;*/

            LoadKategoriak();
        }
        private void LoadKategoriak()
        {
            // Az összes kategória lekérdezése az adatbázisból
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            // TreeView tartalmának törlése
            treeViewKategoriak.Nodes.Clear();

            // Főkategóriák hozzáadása a TreeView-hoz
            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }
        }
        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            // TreeNode létrehozása az aktuális kategóriához
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };

            // Alkategóriák keresése és hozzáadása
            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszeKategoria));
            }

            return node;
        }

        private void átnevezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeViewKategoriak.SelectedNode != null) ;
                {
                    treeViewKategoriak.SelectedNode.BeginEdit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void újFőkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermekKategoria kat = new TermekKategoria();
            kat.Nev = "Új kategória";
            kat.SzuloKategoriaId = null;
            _context.TermekKategoria.Add(kat);
            _context.SaveChanges();

            TreeNode node = new TreeNode(kat.Nev);
            node.Tag = kat;
            treeViewKategoriak.Nodes.Add(node);

            treeViewKategoriak.SelectedNode = node;
        }

        private void újAlkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermekKategoria kat = new TermekKategoria();
            kat.Nev = "Új kategória";
            kat.SzuloKategoriaId = ((TermekKategoria)treeViewKategoriak.SelectedNode.Tag).KategoriaId;
            _context.TermekKategoria.Add(kat);
            _context.SaveChanges();

            TreeNode node = new TreeNode(kat.Nev);
            node.Tag = kat;
            treeViewKategoriak.SelectedNode.Nodes.Add(node);

            treeViewKategoriak.SelectedNode = node;
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode.Nodes.Count == 0)
            {
                TermekKategoria kat = (TermekKategoria)treeViewKategoriak.SelectedNode.Tag;
                _context.TermekKategoria.Remove(kat);
                _context.SaveChanges();

                treeViewKategoriak.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Nem törölhető a kategória, mert van alkategóriája!");
            }
        }

        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kategoriak = (from k in _context.TermekKategoria select k).ToList();
            var fokategoriak = from k in kategoriak where k.SzuloKategoriaId == null select k;
            treeViewKategoriak.Nodes.Clear();
            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);

            }
        }



            private XElement CreateXmlElement(TermekKategoria kategoria, List<TermekKategoria> kategoriak)
        {
            XElement element = new XElement("Kategoria",
        new XAttribute("KategoriaId", kategoria.KategoriaId),
        new XAttribute("Nev", kategoria.Nev));

            var alkategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var alkategoria in alkategoriak)
            {
                XElement alkategoriaElement = CreateXmlElement(alkategoria, kategoriak);
                element.Add(alkategoriaElement);
            }

            return element;
        }



        private void treeViewKategoriak_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeViewKategoriak.SelectedNode = e.Node;
                contextMenuStripKategoria.Show(treeViewKategoriak, e.Location);
            }
        }

        private void xMLFájlMentéseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument();

            XDeclaration xdecl = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Declaration = xdecl;

            XElement root = new XElement("Kategoriak");
            xdoc.Add(root);

            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();


            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var kategoria in fokategoriak)
            {
                XElement kategoriaElement = CreateXmlElement(kategoria, kategoriak);
                root.Add(kategoriaElement);

                //var node = CreateTreeNode(kategoria, kategoriak);
                //treeViewKategoriak.Nodes.Add(node);
            }



            MessageBox.Show(xdoc.ToString());
        }

        private void Mentés_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNev.Text))
            {
                MessageBox.Show("A név mező nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (isNewItem)
                {
                    newKategoria.Nev = txtNev.Text;
                    newKategoria.Leiras = txtLeiras.Text;
                    _context.TermekKategoria.Add(newKategoria);
                }
                else if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
                {
                    selectedKategoria.Nev = txtNev.Text; selectedKategoria.Leiras = txtLeiras.Text;
                }
                _context.SaveChanges();
                MessageBox.Show("A változtatások sikeresen mentve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKategoriak();
                isNewItem = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonbro_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                newKategoria = new TermekKategoria { SzuloKategoriaId = selectedKategoria.SzuloKategoriaId };
                txtNev.Clear();
                txtLeiras.Clear();
                isNewItem = true;
            }
        }

        private void buttonkid_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                newKategoria = new TermekKategoria { SzuloKategoriaId = selectedKategoria.KategoriaId };
                txtNev.Clear();
                txtLeiras.Clear();
                isNewItem = true;
            }
        }

        private void Törlés_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                var result = MessageBox.Show($"Biztosan törölni szeretné a(z) '{selectedKategoria.Nev}' kategóriát és annak összes alkategóriáját?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DeleteKategoriaAndChildren(selectedKategoria);
                        _context.SaveChanges();
                        MessageBox.Show("A kategória és alkategóriái sikeresen törölve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKategoriak();
                        txtNev.Clear();
                        txtLeiras.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a törlés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérjük, válasszon ki egy kategóriát a törléshez!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteKategoriaAndChildren(TermekKategoria kategoria)
        {
            var childrenToDelete = (from k in _context.TermekKategoria where k.SzuloKategoriaId == kategoria.KategoriaId select k).ToList();
            foreach (var child in childrenToDelete)
            { DeleteKategoriaAndChildren(child); }
            _context.TermekKategoria.Remove(kategoria);
        }
        private void treeViewKategoriak_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null && !string.IsNullOrEmpty(e.Label))
            {
                TermekKategoria kat = (TermekKategoria)e.Node.Tag;
                kat.Nev = e.Label;
                _context.SaveChanges();
            }
        }
        private void treeViewKategoriak_MouseDown(object sender, MouseEventArgs e)
        {
            // Step 1: Check if the right mouse button is clicked
            if (e.Button == MouseButtons.Right)
            {
                // Step 2: Get the node at the mouse position
                TreeNode clickedNode = treeViewKategoriak.GetNodeAt(e.X, e.Y);

                if (clickedNode != null)
                {
                    // Step 3: Select the node under the cursor
                    treeViewKategoriak.SelectedNode = clickedNode;

                    // Step 4: Show the context menu at the mouse position
                    contextMenuStripKategoria.Show(treeViewKategoriak, e.Location);
                }
            }
        }
        /*private void xMLFájlbaMentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument();

            XDeclaration xdecl = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Declaration = xdecl;

            XElement root = new XElement("Kategoriak");
            xdoc.Add(root);

            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();


            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var kategoria in fokategoriak)
            {
                XElement kategoriaElement = CreateXmlElement(kategoria, kategoriak);
                root.Add(kategoriaElement);
            }

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "XML fájlok(*xml)|*.xml";
                saveFile.Title = "XML fájlba mentés";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    xdoc.Save(saveFile.FileName);
                }
            }
        }
        private XElement CreateXmlElement(TermekKategoria kategoria, List<TermekKategoria> kategoriak)
        {
            XElement element = new XElement("Kategoria",
                new XAttribute("KategoriaId", kategoria.KategoriaId),
                new XAttribute("Nev", kategoria.Nev));

            //Termék hozzáadása
            var termekek = from t in _context.Termek where t.KategoriaId == kategoria.KategoriaId select t;

            foreach (var item in termekek)
            {
                XElement termekElement = new XElement("Termek",
                    new XAttribute("TermekID", item.TermekId),
                    new XAttribute("Nev", item.Nev));
                element.Add(termekElement);
            }

            var alkategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var alkategoria in alkategoriak)
            {
                XElement alkategoriaElement = CreateXmlElement(alkategoria, kategoriak);
                element.Add(alkategoriaElement);
            }

            return element;
        }*/
    }
}
