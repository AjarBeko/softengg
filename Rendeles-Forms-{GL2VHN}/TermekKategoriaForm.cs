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
        RendelesDbContext _context = new RendelesDbContext();
        public TermekKategoriaForm()
        {
            InitializeComponent();
            TreeNode ujKat = new TreeNode("ÚJ");
            treeViewKategoriak.Nodes.Add(ujKat);

            TermekKategoria tk = new TermekKategoria();
            tk.Nev = ujKat.Text;
            tk.SzuloKategoria = null;
            _context.TermekKategoria.Add(tk);
            _context.SaveChanges();
            ujKat.Tag = tk;

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

        }

        private void újAlkategóriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frissítésToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // TermekKategoria átvevezettKategoria = (TermekKategoria)e.node.tag;
            //_context.SaveChanges();
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
    }
}
