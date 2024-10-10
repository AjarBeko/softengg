namespace Rendeles_Forms__GL2VHN_
{
    partial class UgyfelSzerkesztesFormcs
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            tbNev = new TextBox();
            ugyfelBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Név";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefonszám";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 274);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Ország";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 313);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 4;
            label5.Text = "Irányítószám";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 350);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 5;
            label6.Text = "Város";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 388);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 6;
            label7.Text = "Utca";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 423);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 7;
            label8.Text = "Házszám";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 144);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(170, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Létező cím beállítása";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(396, 28);
            comboBox1.TabIndex = 9;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 226);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(140, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Új cím beállítása";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 464);
            button1.Name = "button1";
            button1.Size = new Size(384, 54);
            button1.TabIndex = 11;
            button1.Text = "Új elem hozzáadása";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(12, 524);
            button2.Name = "button2";
            button2.Size = new Size(384, 56);
            button2.TabIndex = 12;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // tbNev
            // 
            tbNev.Location = new Point(110, 6);
            tbNev.Name = "tbNev";
            tbNev.Size = new Size(328, 27);
            tbNev.TabIndex = 21;
            tbNev.Validating += tbNev_Validating;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Email", true));
            textBox2.Location = new Point(110, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 27);
            textBox2.TabIndex = 14;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Telefonszam", true));
            textBox3.Location = new Point(110, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(328, 27);
            textBox3.TabIndex = 15;
            textBox3.Validating += textBox3_Validating;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 267);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(328, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(110, 310);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(328, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(110, 350);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(328, 27);
            textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(110, 385);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(328, 27);
            textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(110, 423);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(328, 27);
            textBox8.TabIndex = 20;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UgyfelSzerkesztesFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 592);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(tbNev);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(comboBox1);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UgyfelSzerkesztesFormcs";
            Text = "UgyfelSzerkesztesFormcs";
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private TextBox tbNev;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private BindingSource ugyfelBindingSource;
        private ErrorProvider errorProvider1;
    }
}