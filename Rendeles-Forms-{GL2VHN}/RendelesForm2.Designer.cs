namespace Rendeles_Forms__GL2VHN_
{
    partial class RendelesFrom2
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
            ugyelek_listbox = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            rendelesek_listbox = new ListBox();
            rendelesBindingSource = new BindingSource(components);
            termekek_listbox = new ListBox();
            termekBindingSource = new BindingSource(components);
            ugyfelszures_textbox = new TextBox();
            cim_combobox = new ComboBox();
            statusz_combobox = new ComboBox();
            kedvezmeny_textbox = new TextBox();
            mennyiseg_textbox = new TextBox();
            ujrendeles_button = new Button();
            tetelhozzaad_button = new Button();
            teteltorles_button = new Button();
            mentes_button = new Button();
            excelexport_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            rendelesTetelBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            UserControl1 = new Button();
            UserControl2 = new Button();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ugyelek_listbox
            // 
            ugyelek_listbox.DataSource = ugyfelBindingSource;
            ugyelek_listbox.DisplayMember = "Nev";
            ugyelek_listbox.FormattingEnabled = true;
            ugyelek_listbox.ItemHeight = 20;
            ugyelek_listbox.Location = new Point(0, 142);
            ugyelek_listbox.Name = "ugyelek_listbox";
            ugyelek_listbox.Size = new Size(184, 544);
            ugyelek_listbox.TabIndex = 0;
            ugyelek_listbox.ValueMember = "UgyfelId";
            ugyelek_listbox.SelectedIndexChanged += ugyelek_listbox_SelectedIndexChanged;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // rendelesek_listbox
            // 
            rendelesek_listbox.DataSource = rendelesBindingSource;
            rendelesek_listbox.DisplayMember = "RendelesDatum";
            rendelesek_listbox.FormattingEnabled = true;
            rendelesek_listbox.ItemHeight = 20;
            rendelesek_listbox.Location = new Point(190, 142);
            rendelesek_listbox.Name = "rendelesek_listbox";
            rendelesek_listbox.Size = new Size(209, 544);
            rendelesek_listbox.TabIndex = 1;
            rendelesek_listbox.ValueMember = "RendelesId";
            rendelesek_listbox.SelectedIndexChanged += rendelesek_listbox_SelectedIndexChanged;
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // termekek_listbox
            // 
            termekek_listbox.DataSource = termekBindingSource;
            termekek_listbox.DisplayMember = "Nev";
            termekek_listbox.FormattingEnabled = true;
            termekek_listbox.ItemHeight = 20;
            termekek_listbox.Location = new Point(1712, 142);
            termekek_listbox.Name = "termekek_listbox";
            termekek_listbox.Size = new Size(203, 544);
            termekek_listbox.TabIndex = 2;
            termekek_listbox.ValueMember = "TermekId";
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // ugyfelszures_textbox
            // 
            ugyfelszures_textbox.Location = new Point(0, 72);
            ugyfelszures_textbox.Name = "ugyfelszures_textbox";
            ugyfelszures_textbox.Size = new Size(184, 27);
            ugyfelszures_textbox.TabIndex = 4;
            ugyfelszures_textbox.TextChanged += ugyfelszures_textbox_TextChanged;
            // 
            // cim_combobox
            // 
            cim_combobox.DataBindings.Add(new Binding("Text", rendelesBindingSource, "SzallitasiCimId", true, DataSourceUpdateMode.OnPropertyChanged));
            cim_combobox.FormattingEnabled = true;
            cim_combobox.Location = new Point(405, 94);
            cim_combobox.Name = "cim_combobox";
            cim_combobox.Size = new Size(484, 28);
            cim_combobox.TabIndex = 5;
            
            // 
            // statusz_combobox
            // 
            statusz_combobox.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Statusz", true, DataSourceUpdateMode.OnPropertyChanged));
            statusz_combobox.FormattingEnabled = true;
            statusz_combobox.Items.AddRange(new object[] { "Feldolgozás alatt", "Szállítás", "Kiszállítva", "Törölve" });
            statusz_combobox.Location = new Point(1126, 94);
            statusz_combobox.Name = "statusz_combobox";
            statusz_combobox.Size = new Size(151, 28);
            statusz_combobox.TabIndex = 6;
            // 
            // kedvezmeny_textbox
            // 
            kedvezmeny_textbox.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Kedvezmeny", true, DataSourceUpdateMode.OnPropertyChanged, "0", "0.00%"));
            kedvezmeny_textbox.Location = new Point(927, 94);
            kedvezmeny_textbox.Name = "kedvezmeny_textbox";
            kedvezmeny_textbox.Size = new Size(159, 27);
            kedvezmeny_textbox.TabIndex = 7;
            // 
            // mennyiseg_textbox
            // 
            mennyiseg_textbox.Location = new Point(1581, 281);
            mennyiseg_textbox.Name = "mennyiseg_textbox";
            mennyiseg_textbox.Size = new Size(125, 27);
            mennyiseg_textbox.TabIndex = 8;
            // 
            // ujrendeles_button
            // 
            ujrendeles_button.Location = new Point(190, 697);
            ujrendeles_button.Name = "ujrendeles_button";
            ujrendeles_button.Size = new Size(209, 42);
            ujrendeles_button.TabIndex = 9;
            ujrendeles_button.Text = "Új rendelés";
            ujrendeles_button.UseVisualStyleBackColor = true;
            ujrendeles_button.Click += ujrendeles_button_Click;
            // 
            // tetelhozzaad_button
            // 
            tetelhozzaad_button.Location = new Point(1581, 314);
            tetelhozzaad_button.Name = "tetelhozzaad_button";
            tetelhozzaad_button.Size = new Size(125, 49);
            tetelhozzaad_button.TabIndex = 10;
            tetelhozzaad_button.Text = "Tétel hozzáadása";
            tetelhozzaad_button.UseVisualStyleBackColor = true;
            tetelhozzaad_button.Click += tetelhozzaad_button_Click;
            // 
            // teteltorles_button
            // 
            teteltorles_button.Location = new Point(1580, 384);
            teteltorles_button.Name = "teteltorles_button";
            teteltorles_button.Size = new Size(126, 29);
            teteltorles_button.TabIndex = 11;
            teteltorles_button.Text = "Tétel törlése";
            teteltorles_button.UseVisualStyleBackColor = true;
            teteltorles_button.Click += teteltorles_button_Click;
            // 
            // mentes_button
            // 
            mentes_button.Location = new Point(1211, 704);
            mentes_button.Name = "mentes_button";
            mentes_button.Size = new Size(127, 29);
            mentes_button.TabIndex = 12;
            mentes_button.Text = "Mentés";
            mentes_button.UseVisualStyleBackColor = true;
            // 
            // excelexport_button
            // 
            excelexport_button.Location = new Point(1344, 704);
            excelexport_button.Name = "excelexport_button";
            excelexport_button.Size = new Size(127, 29);
            excelexport_button.TabIndex = 13;
            excelexport_button.Text = "Excel export";
            excelexport_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 49);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 14;
            label1.Text = "Ügyfelek szűrése";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 119);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 15;
            label2.Text = "Ügyfelek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 119);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 16;
            label3.Text = "Rendelések";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 71);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 17;
            label4.Text = "Rendelés címe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(927, 71);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 18;
            label5.Text = "Kedvezmény";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1126, 70);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 19;
            label6.Text = "Státusz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(443, 708);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1580, 248);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 21;
            label8.Text = "Mennyiség";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1712, 119);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 22;
            label9.Text = "Termékek";
            // 
            // rendelesTetelBindingSource
            // 
            rendelesTetelBindingSource.DataSource = typeof(Models.RendelesTetel);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(405, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1066, 540);
            dataGridView1.TabIndex = 23;
            // 
            // UserControl1
            // 
            UserControl1.Location = new Point(0, 0);
            UserControl1.Name = "UserControl1";
            UserControl1.Size = new Size(75, 23);
            UserControl1.TabIndex = 28;
            // 
            // UserControl2
            // 
            UserControl2.Location = new Point(0, 0);
            UserControl2.Name = "UserControl2";
            UserControl2.Size = new Size(75, 23);
            UserControl2.TabIndex = 27;
            // 
            // RendelesFrom2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(UserControl2);
            Controls.Add(UserControl1);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(excelexport_button);
            Controls.Add(mentes_button);
            Controls.Add(teteltorles_button);
            Controls.Add(tetelhozzaad_button);
            Controls.Add(ujrendeles_button);
            Controls.Add(mennyiseg_textbox);
            Controls.Add(kedvezmeny_textbox);
            Controls.Add(statusz_combobox);
            Controls.Add(cim_combobox);
            Controls.Add(ugyfelszures_textbox);
            Controls.Add(termekek_listbox);
            Controls.Add(rendelesek_listbox);
            Controls.Add(ugyelek_listbox);
            Name = "RendelesFrom2";
            Text = "RendelesForm2";
            Load += RendelesFrom2_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ugyelek_listbox;
        private ListBox rendelesek_listbox;
        private ListBox termekek_listbox;
        private TextBox ugyfelszures_textbox;
        private ComboBox cim_combobox;
        private ComboBox statusz_combobox;
        private TextBox kedvezmeny_textbox;
        private TextBox mennyiseg_textbox;
        private Button ujrendeles_button;
        private Button tetelhozzaad_button;
        private Button teteltorles_button;
        private Button mentes_button;
        private Button excelexport_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private BindingSource ugyfelBindingSource;
        private BindingSource termekBindingSource;
        private BindingSource rendelesBindingSource;
        private BindingSource rendelesTetelBindingSource;
        private DataGridView dataGridView1;
        private Button UserControl1;
        private Button UserControl2;
    }
}