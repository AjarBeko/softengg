namespace Rendeles_Forms__GL2VHN_
{
    partial class UgyfelLisaForm
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
            dataGridView1 = new DataGridView();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            ujugyfel = new Button();
            ugyfelmodosit = new Button();
            ugyfeltorol = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ugyfelIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ugyfelBindingSource;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(784, 351);
            dataGridView1.TabIndex = 0;
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            ugyfelIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.MinimumWidth = 6;
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            telefonszamDataGridViewTextBoxColumn.Width = 125;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(777, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ujugyfel
            // 
            ujugyfel.Location = new Point(33, 411);
            ujugyfel.Name = "ujugyfel";
            ujugyfel.Size = new Size(241, 29);
            ujugyfel.TabIndex = 2;
            ujugyfel.Text = "Új ügyfél hozzáadása";
            ujugyfel.UseVisualStyleBackColor = true;
            ujugyfel.Click += ujugyfel_Click;
            // 
            // ugyfelmodosit
            // 
            ugyfelmodosit.Location = new Point(303, 411);
            ugyfelmodosit.Name = "ugyfelmodosit";
            ugyfelmodosit.Size = new Size(232, 29);
            ugyfelmodosit.TabIndex = 3;
            ugyfelmodosit.Text = "Ügyfél módosítása";
            ugyfelmodosit.UseVisualStyleBackColor = true;
            ugyfelmodosit.Click += ugyfelmodosit_Click;
            // 
            // ugyfeltorol
            // 
            ugyfeltorol.Location = new Point(573, 411);
            ugyfeltorol.Name = "ugyfeltorol";
            ugyfeltorol.Size = new Size(221, 29);
            ugyfeltorol.TabIndex = 4;
            ugyfeltorol.Text = "Ügyfél törlése";
            ugyfeltorol.UseVisualStyleBackColor = true;
            ugyfeltorol.Click += ugyfeltorol_Click;
            // 
            // UgyfelLisaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ugyfeltorol);
            Controls.Add(ugyfelmodosit);
            Controls.Add(ujugyfel);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "UgyfelLisaForm";
            Text = "UgyfelLisaForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button ujugyfel;
        private Button ugyfelmodosit;
        private Button ugyfeltorol;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private BindingSource ugyfelBindingSource;
    }
}