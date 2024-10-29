namespace Rendeles_Forms__GL2VHN_
{
    partial class RendelesForm
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
            ugyfellist = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            rendeleslist = new ListBox();
            rendelesBindingSource = new BindingSource(components);
            termekeklist = new ListBox();
            termekBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            rendelesTetelBindingSource = new BindingSource(components);
            ugyfelszur = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            kedvezmeny = new TextBox();
            rendelescime = new ComboBox();
            statusz = new ComboBox();
            textBox3 = new TextBox();
            tetelhozzaad = new Button();
            teteltorol = new Button();
            mentes = new Button();
            excelexport = new Button();
            ujrendeles = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ugyfellist
            // 
            ugyfellist.DataSource = ugyfelBindingSource;
            ugyfellist.DisplayMember = "Nev";
            ugyfellist.FormattingEnabled = true;
            ugyfellist.ItemHeight = 20;
            ugyfellist.Location = new Point(14, 107);
            ugyfellist.Margin = new Padding(3, 4, 3, 4);
            ugyfellist.Name = "ugyfellist";
            ugyfellist.Size = new Size(155, 624);
            ugyfellist.TabIndex = 0;
            ugyfellist.ValueMember = "UgyfelId";
            ugyfellist.SelectedIndexChanged += ugyfellist_SelectedIndexChanged;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // rendeleslist
            // 
            rendeleslist.DataSource = rendelesBindingSource;
            rendeleslist.DisplayMember = "RendelesDatum";
            rendeleslist.FormattingEnabled = true;
            rendeleslist.ItemHeight = 20;
            rendeleslist.Location = new Point(176, 207);
            rendeleslist.Margin = new Padding(3, 4, 3, 4);
            rendeleslist.Name = "rendeleslist";
            rendeleslist.Size = new Size(170, 524);
            rendeleslist.TabIndex = 1;
            rendeleslist.ValueMember = "RendelesId";
            rendeleslist.SelectedIndexChanged += rendeleslist_SelectedIndexChanged;
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // termekeklist
            // 
            termekeklist.DataSource = termekBindingSource;
            termekeklist.DisplayMember = "Nev";
            termekeklist.FormattingEnabled = true;
            termekeklist.ItemHeight = 20;
            termekeklist.Location = new Point(1482, 132);
            termekeklist.Margin = new Padding(3, 4, 3, 4);
            termekeklist.Name = "termekeklist";
            termekeklist.Size = new Size(246, 624);
            termekeklist.TabIndex = 2;
            termekeklist.ValueMember = "TermekId";
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 196);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(952, 536);
            dataGridView1.TabIndex = 3;
            // 
            // rendelesTetelBindingSource
            // 
            rendelesTetelBindingSource.DataSource = typeof(Models.RendelesTetel);
            // 
            // ugyfelszur
            // 
            ugyfelszur.Location = new Point(14, 39);
            ugyfelszur.Margin = new Padding(3, 4, 3, 4);
            ugyfelszur.Name = "ugyfelszur";
            ugyfelszur.Size = new Size(260, 27);
            ugyfelszur.TabIndex = 4;
            ugyfelszur.TextChanged += ugyfelszur_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 5;
            label1.Text = "Ügyfelek szűrése";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 83);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "Ügyfelek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 183);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 7;
            label3.Text = "Rendelések";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 113);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 8;
            label4.Text = "Rendeléscíme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 107);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 9;
            label5.Text = "Kedvezmény";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(738, 107);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 10;
            label6.Text = "Státusz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1379, 293);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 11;
            label7.Text = "Mennyiség";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1482, 107);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 12;
            label8.Text = "Termékek";
            // 
            // kedvezmeny
            // 
            kedvezmeny.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Kedvezmeny", true, DataSourceUpdateMode.OnPropertyChanged, "0", "0.00%"));
            kedvezmeny.Location = new Point(617, 137);
            kedvezmeny.Margin = new Padding(3, 4, 3, 4);
            kedvezmeny.Name = "kedvezmeny";
            kedvezmeny.Size = new Size(114, 27);
            kedvezmeny.TabIndex = 13;
            // 
            // rendelescime
            // 
            rendelescime.DataBindings.Add(new Binding("SelectedValue", rendelesBindingSource, "SzallitasiCimId", true));
            rendelescime.DataBindings.Add(new Binding("Text", rendelesBindingSource, "SzallitasiCimId", true, DataSourceUpdateMode.OnPropertyChanged));
            rendelescime.FormattingEnabled = true;
            rendelescime.Location = new Point(176, 137);
            rendelescime.Margin = new Padding(3, 4, 3, 4);
            rendelescime.Name = "rendelescime";
            rendelescime.Size = new Size(434, 28);
            rendelescime.TabIndex = 14;
            // 
            // statusz
            // 
            statusz.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Statusz", true, DataSourceUpdateMode.OnPropertyChanged));
            statusz.FormattingEnabled = true;
            statusz.Items.AddRange(new object[] { "Feldolgozás alatt", "Szállítás", "Kiszállítva", "Törölve" });
            statusz.Location = new Point(738, 137);
            statusz.Margin = new Padding(3, 4, 3, 4);
            statusz.Name = "statusz";
            statusz.Size = new Size(123, 28);
            statusz.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1379, 317);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 27);
            textBox3.TabIndex = 16;
            // 
            // tetelhozzaad
            // 
            tetelhozzaad.Location = new Point(1379, 352);
            tetelhozzaad.Margin = new Padding(3, 4, 3, 4);
            tetelhozzaad.Name = "tetelhozzaad";
            tetelhozzaad.Size = new Size(97, 57);
            tetelhozzaad.TabIndex = 17;
            tetelhozzaad.Text = "Tétel hozzáadása";
            tetelhozzaad.UseVisualStyleBackColor = true;
            tetelhozzaad.Click += tetelhozzaad_Click;
            // 
            // teteltorol
            // 
            teteltorol.Location = new Point(1379, 417);
            teteltorol.Margin = new Padding(3, 4, 3, 4);
            teteltorol.Name = "teteltorol";
            teteltorol.Size = new Size(97, 44);
            teteltorol.TabIndex = 18;
            teteltorol.Text = "Tétel törlés";
            teteltorol.UseVisualStyleBackColor = true;
            teteltorol.Click += teteltorol_Click;
            // 
            // mentes
            // 
            mentes.Location = new Point(710, 740);
            mentes.Margin = new Padding(3, 4, 3, 4);
            mentes.Name = "mentes";
            mentes.Size = new Size(103, 31);
            mentes.TabIndex = 19;
            mentes.Text = "Mentés";
            mentes.UseVisualStyleBackColor = true;
            // 
            // excelexport
            // 
            excelexport.Location = new Point(819, 740);
            excelexport.Margin = new Padding(3, 4, 3, 4);
            excelexport.Name = "excelexport";
            excelexport.Size = new Size(119, 31);
            excelexport.TabIndex = 20;
            excelexport.Text = "Excel export";
            excelexport.UseVisualStyleBackColor = true;
            // 
            // ujrendeles
            // 
            ujrendeles.Location = new Point(189, 753);
            ujrendeles.Margin = new Padding(3, 4, 3, 4);
            ujrendeles.Name = "ujrendeles";
            ujrendeles.Size = new Size(158, 69);
            ujrendeles.TabIndex = 21;
            ujrendeles.Text = "Új rendelés";
            ujrendeles.UseVisualStyleBackColor = true;
            ujrendeles.Click += ujrendeles_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(388, 745);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 23;
            // 
            // RendelesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 850);
            Controls.Add(label10);
            Controls.Add(ujrendeles);
            Controls.Add(excelexport);
            Controls.Add(mentes);
            Controls.Add(teteltorol);
            Controls.Add(tetelhozzaad);
            Controls.Add(textBox3);
            Controls.Add(statusz);
            Controls.Add(rendelescime);
            Controls.Add(kedvezmeny);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ugyfelszur);
            Controls.Add(dataGridView1);
            Controls.Add(termekeklist);
            Controls.Add(rendeleslist);
            Controls.Add(ugyfellist);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RendelesForm";
            Text = "RendelesForm";
            Load += RendelesForm_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ugyfellist;
        private ListBox rendeleslist;
        private ListBox termekeklist;
        private DataGridView dataGridView1;
        private TextBox ugyfelszur;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox kedvezmeny;
        private ComboBox rendelescime;
        private ComboBox statusz;
        private TextBox textBox3;
        private Button tetelhozzaad;
        private Button teteltorol;
        private Button mentes;
        private Button excelexport;
        private Button ujrendeles;
        private Label label10;
        private BindingSource ugyfelBindingSource;
        private BindingSource termekBindingSource;
        private BindingSource rendelesBindingSource;
        private BindingSource rendelesTetelBindingSource;
    }
}