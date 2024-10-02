namespace Rendeles_Forms__GL2VHN_
{
    partial class TermekKategoriaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeViewKategoriak = new TreeView();
            contextMenuStripKategoria = new ContextMenuStrip(components);
            átnevezésToolStripMenuItem = new ToolStripMenuItem();
            újFőkategóriaToolStripMenuItem = new ToolStripMenuItem();
            újAlkategóriaToolStripMenuItem = new ToolStripMenuItem();
            törlésToolStripMenuItem = new ToolStripMenuItem();
            frissítésToolStripMenuItem = new ToolStripMenuItem();
            xMLFájlMentéseToolStripMenuItem = new ToolStripMenuItem();
            txtNev = new TextBox();
            txtLeiras = new TextBox();
            Mentés = new Button();
            buttonbro = new Button();
            buttonkid = new Button();
            Törlés = new Button();
            contextMenuStripKategoria.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.Location = new Point(-1, -1);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(317, 273);
            treeViewKategoriak.TabIndex = 5;
            treeViewKategoriak.NodeMouseClick += treeViewKategoriak_NodeMouseClick;
            // 
            // contextMenuStripKategoria
            // 
            contextMenuStripKategoria.Items.AddRange(new ToolStripItem[] { átnevezésToolStripMenuItem, újFőkategóriaToolStripMenuItem, újAlkategóriaToolStripMenuItem, törlésToolStripMenuItem, frissítésToolStripMenuItem, xMLFájlMentéseToolStripMenuItem });
            contextMenuStripKategoria.Name = "contextMenuStripKategoria";
            contextMenuStripKategoria.Size = new Size(181, 158);
            // 
            // átnevezésToolStripMenuItem
            // 
            átnevezésToolStripMenuItem.Name = "átnevezésToolStripMenuItem";
            átnevezésToolStripMenuItem.Size = new Size(180, 22);
            átnevezésToolStripMenuItem.Text = "Átnevezés";
            átnevezésToolStripMenuItem.Click += átnevezésToolStripMenuItem_Click;
            // 
            // újFőkategóriaToolStripMenuItem
            // 
            újFőkategóriaToolStripMenuItem.Name = "újFőkategóriaToolStripMenuItem";
            újFőkategóriaToolStripMenuItem.Size = new Size(180, 22);
            újFőkategóriaToolStripMenuItem.Text = "Új főkategória";
            újFőkategóriaToolStripMenuItem.Click += újFőkategóriaToolStripMenuItem_Click;
            // 
            // újAlkategóriaToolStripMenuItem
            // 
            újAlkategóriaToolStripMenuItem.Name = "újAlkategóriaToolStripMenuItem";
            újAlkategóriaToolStripMenuItem.Size = new Size(180, 22);
            újAlkategóriaToolStripMenuItem.Text = "Új alkategória";
            újAlkategóriaToolStripMenuItem.Click += újAlkategóriaToolStripMenuItem_Click;
            // 
            // törlésToolStripMenuItem
            // 
            törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            törlésToolStripMenuItem.Size = new Size(180, 22);
            törlésToolStripMenuItem.Text = "Törlés";
            törlésToolStripMenuItem.Click += törlésToolStripMenuItem_Click;
            // 
            // frissítésToolStripMenuItem
            // 
            frissítésToolStripMenuItem.Name = "frissítésToolStripMenuItem";
            frissítésToolStripMenuItem.Size = new Size(180, 22);
            frissítésToolStripMenuItem.Text = "Frissítés";
            frissítésToolStripMenuItem.Click += frissítésToolStripMenuItem_Click;
            // 
            // xMLFájlMentéseToolStripMenuItem
            // 
            xMLFájlMentéseToolStripMenuItem.Name = "xMLFájlMentéseToolStripMenuItem";
            xMLFájlMentéseToolStripMenuItem.Size = new Size(180, 22);
            xMLFájlMentéseToolStripMenuItem.Text = "XML fájl mentése";
            xMLFájlMentéseToolStripMenuItem.Click += xMLFájlMentéseToolStripMenuItem_Click_1;
            // 
            // txtNev
            // 
            txtNev.Location = new Point(392, 36);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(341, 23);
            txtNev.TabIndex = 1;
            // 
            // txtLeiras
            // 
            txtLeiras.Location = new Point(392, 103);
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(341, 23);
            txtLeiras.TabIndex = 2;
            // 
            // Mentés
            // 
            Mentés.Location = new Point(637, 289);
            Mentés.Name = "Mentés";
            Mentés.Size = new Size(75, 23);
            Mentés.TabIndex = 4;
            Mentés.Text = "Mentés";
            // 
            // buttonbro
            // 
            buttonbro.Location = new Point(544, 289);
            buttonbro.Name = "buttonbro";
            buttonbro.Size = new Size(75, 23);
            buttonbro.TabIndex = 3;
            buttonbro.Text = "Új testvér";
            // 
            // buttonkid
            // 
            buttonkid.Location = new Point(437, 289);
            buttonkid.Name = "buttonkid";
            buttonkid.Size = new Size(75, 23);
            buttonkid.TabIndex = 2;
            buttonkid.Text = "új kid";
            // 
            // Törlés
            // 
            Törlés.Location = new Point(338, 289);
            Törlés.Name = "Törlés";
            Törlés.Size = new Size(75, 23);
            Törlés.TabIndex = 1;
            Törlés.Text = "Törlés";
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Törlés);
            Controls.Add(buttonkid);
            Controls.Add(buttonbro);
            Controls.Add(Mentés);
            Controls.Add(txtLeiras);
            Controls.Add(txtNev);
            Controls.Add(treeViewKategoriak);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            contextMenuStripKategoria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox txtNev;
        private TextBox txtLeiras;
        private Button Mentés;
        private Button buttonbro;
        private Button buttonkid;
        private Button Törlés;
        private ContextMenuStrip contextMenuStripKategoria;
        private ToolStripMenuItem átnevezésToolStripMenuItem;
        private ToolStripMenuItem újFőkategóriaToolStripMenuItem;
        private ToolStripMenuItem újAlkategóriaToolStripMenuItem;
        private ToolStripMenuItem törlésToolStripMenuItem;
        private ToolStripMenuItem frissítésToolStripMenuItem;
        private ToolStripMenuItem xMLFájlMentéseToolStripMenuItem;
    }
}