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
            termekeklist = new ListBox();
            termekBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
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
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            rendelesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ugyfellist
            // 
            ugyfellist.DataSource = ugyfelBindingSource;
            ugyfellist.DisplayMember = "Nev";
            ugyfellist.FormattingEnabled = true;
            ugyfellist.ItemHeight = 15;
            ugyfellist.Location = new Point(12, 80);
            ugyfellist.Name = "ugyfellist";
            ugyfellist.Size = new Size(136, 469);
            ugyfellist.TabIndex = 0;
            ugyfellist.ValueMember = "UgyfelId";
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
            rendeleslist.ItemHeight = 15;
            rendeleslist.Location = new Point(154, 155);
            rendeleslist.Name = "rendeleslist";
            rendeleslist.Size = new Size(149, 394);
            rendeleslist.TabIndex = 1;
            rendeleslist.ValueMember = "RendelesId";
            // 
            // termekeklist
            // 
            termekeklist.DataSource = termekBindingSource;
            termekeklist.DisplayMember = "Nev";
            termekeklist.FormattingEnabled = true;
            termekeklist.ItemHeight = 15;
            termekeklist.Location = new Point(923, 80);
            termekeklist.Name = "termekeklist";
            termekeklist.Size = new Size(216, 469);
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
            dataGridView1.Location = new Point(312, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(509, 402);
            dataGridView1.TabIndex = 3;
            // 
            // ugyfelszur
            // 
            ugyfelszur.Location = new Point(12, 29);
            ugyfelszur.Name = "ugyfelszur";
            ugyfelszur.Size = new Size(228, 23);
            ugyfelszur.TabIndex = 4;
            ugyfelszur.TextChanged += ugyfelszur_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Ügyfelek szűrése";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Ügyfelek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Rendelések";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 85);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "Rendeléscíme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(540, 80);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 9;
            label5.Text = "Kedvezmény";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(646, 80);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 10;
            label6.Text = "Státusz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(827, 231);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 11;
            label7.Text = "Mennyiség";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(923, 62);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 12;
            label8.Text = "Termékek";
            // 
            // kedvezmeny
            // 
            kedvezmeny.Location = new Point(540, 103);
            kedvezmeny.Name = "kedvezmeny";
            kedvezmeny.Size = new Size(100, 23);
            kedvezmeny.TabIndex = 13;
            // 
            // rendelescime
            // 
            rendelescime.FormattingEnabled = true;
            rendelescime.Location = new Point(154, 103);
            rendelescime.Name = "rendelescime";
            rendelescime.Size = new Size(380, 23);
            rendelescime.TabIndex = 14;
            // 
            // statusz
            // 
            statusz.FormattingEnabled = true;
            statusz.Location = new Point(646, 103);
            statusz.Name = "statusz";
            statusz.Size = new Size(108, 23);
            statusz.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(827, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 23);
            textBox3.TabIndex = 16;
            // 
            // tetelhozzaad
            // 
            tetelhozzaad.Location = new Point(827, 288);
            tetelhozzaad.Name = "tetelhozzaad";
            tetelhozzaad.Size = new Size(85, 43);
            tetelhozzaad.TabIndex = 17;
            tetelhozzaad.Text = "Tétel hozzáadása";
            tetelhozzaad.UseVisualStyleBackColor = true;
            // 
            // teteltorol
            // 
            teteltorol.Location = new Point(827, 337);
            teteltorol.Name = "teteltorol";
            teteltorol.Size = new Size(85, 33);
            teteltorol.TabIndex = 18;
            teteltorol.Text = "Tétel törlés";
            teteltorol.UseVisualStyleBackColor = true;
            // 
            // mentes
            // 
            mentes.Location = new Point(621, 555);
            mentes.Name = "mentes";
            mentes.Size = new Size(90, 23);
            mentes.TabIndex = 19;
            mentes.Text = "Mentés";
            mentes.UseVisualStyleBackColor = true;
            // 
            // excelexport
            // 
            excelexport.Location = new Point(717, 555);
            excelexport.Name = "excelexport";
            excelexport.Size = new Size(104, 23);
            excelexport.TabIndex = 20;
            excelexport.Text = "Excel export";
            excelexport.UseVisualStyleBackColor = true;
            // 
            // ujrendeles
            // 
            ujrendeles.Location = new Point(165, 565);
            ujrendeles.Name = "ujrendeles";
            ujrendeles.Size = new Size(138, 52);
            ujrendeles.TabIndex = 21;
            ujrendeles.Text = "Új rendelés";
            ujrendeles.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(313, 552);
            label9.Name = "label9";
            label9.Size = new Size(130, 15);
            label9.TabIndex = 22;
            label9.Text = "A rendelés teljes értéke:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(449, 552);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(449, 552);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 24;
            label11.Text = "label11";
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // RendelesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 629);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
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
            Name = "RendelesForm";
            Text = "RendelesForm";
            Load += RendelesForm_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
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
        private Label label9;
        private Label label10;
        private Label label11;
        private BindingSource ugyfelBindingSource;
        private BindingSource termekBindingSource;
        private BindingSource rendelesBindingSource;
    }
}