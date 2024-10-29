namespace Rendeles_Forms__GL2VHN_
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            rendeles = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 42);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 31);
            button1.TabIndex = 0;
            button1.Text = "Új";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 81);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(119, 31);
            button2.TabIndex = 1;
            button2.Text = "Főmenü";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 119);
            button3.Name = "button3";
            button3.Size = new Size(119, 29);
            button3.TabIndex = 2;
            button3.Text = "Ügyfél Lista";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // rendeles
            // 
            rendeles.Location = new Point(3, 155);
            rendeles.Margin = new Padding(3, 4, 3, 4);
            rendeles.Name = "rendeles";
            rendeles.Size = new Size(119, 31);
            rendeles.TabIndex = 3;
            rendeles.Text = "Rendelések";
            rendeles.UseVisualStyleBackColor = true;
            rendeles.Click += rendeles_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 193);
            button4.Name = "button4";
            button4.Size = new Size(119, 29);
            button4.TabIndex = 4;
            button4.Text = "Rendelések2.0";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button4);
            Controls.Add(rendeles);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button rendeles;
        private Button button4;
    }
}