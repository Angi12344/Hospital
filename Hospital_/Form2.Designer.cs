namespace Hospital_
{
    partial class Form2
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Yearslabel = new System.Windows.Forms.Label();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.SecondNamelabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Editbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(59, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 22);
            this.textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(328, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 16;
            // 
            // Yearslabel
            // 
            this.Yearslabel.AutoSize = true;
            this.Yearslabel.Location = new System.Drawing.Point(56, 188);
            this.Yearslabel.Name = "Yearslabel";
            this.Yearslabel.Size = new System.Drawing.Size(40, 16);
            this.Yearslabel.TabIndex = 15;
            this.Yearslabel.Text = "Edad";
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.AutoSize = true;
            this.FirstNamelabel.Location = new System.Drawing.Point(18, 90);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(69, 16);
            this.FirstNamelabel.TabIndex = 14;
            this.FirstNamelabel.Text = "A. Paterno";
            // 
            // SecondNamelabel
            // 
            this.SecondNamelabel.AutoSize = true;
            this.SecondNamelabel.Location = new System.Drawing.Point(190, 90);
            this.SecondNamelabel.Name = "SecondNamelabel";
            this.SecondNamelabel.Size = new System.Drawing.Size(71, 16);
            this.SecondNamelabel.TabIndex = 13;
            this.SecondNamelabel.Text = "A, Materno";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(339, 90);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(63, 16);
            this.Namelabel.TabIndex = 12;
            this.Namelabel.Text = "Nombres";
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(444, 204);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(96, 39);
            this.Editbutton.TabIndex = 20;
            this.Editbutton.Text = "Actualizar";
            this.Editbutton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(552, 255);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Yearslabel);
            this.Controls.Add(this.FirstNamelabel);
            this.Controls.Add(this.SecondNamelabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "Form2";
            this.Text = "Actualizar datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Yearslabel;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Label SecondNamelabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button Editbutton;
    }
}