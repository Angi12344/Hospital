namespace Hospital_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SectorcomboBox = new System.Windows.Forms.ComboBox();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.NameCompletetextBox = new System.Windows.Forms.TextBox();
            this.SecondNametextBox = new System.Windows.Forms.TextBox();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.Yearslabel = new System.Windows.Forms.Label();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.SecondNamelabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Sector2comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SectorcomboBox);
            this.tabPage1.Controls.Add(this.AgetextBox);
            this.tabPage1.Controls.Add(this.NameCompletetextBox);
            this.tabPage1.Controls.Add(this.SecondNametextBox);
            this.tabPage1.Controls.Add(this.FirstNametextBox);
            this.tabPage1.Controls.Add(this.Yearslabel);
            this.tabPage1.Controls.Add(this.FirstNamelabel);
            this.tabPage1.Controls.Add(this.SecondNamelabel);
            this.tabPage1.Controls.Add(this.Namelabel);
            this.tabPage1.Controls.Add(this.Addbutton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingrese los siguienes datos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sector:";
            // 
            // SectorcomboBox
            // 
            this.SectorcomboBox.FormattingEnabled = true;
            this.SectorcomboBox.Location = new System.Drawing.Point(297, 262);
            this.SectorcomboBox.Name = "SectorcomboBox";
            this.SectorcomboBox.Size = new System.Drawing.Size(140, 24);
            this.SectorcomboBox.TabIndex = 13;
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(109, 262);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(90, 22);
            this.AgetextBox.TabIndex = 11;
            // 
            // NameCompletetextBox
            // 
            this.NameCompletetextBox.Location = new System.Drawing.Point(341, 102);
            this.NameCompletetextBox.Name = "NameCompletetextBox";
            this.NameCompletetextBox.Size = new System.Drawing.Size(212, 22);
            this.NameCompletetextBox.TabIndex = 10;
            // 
            // SecondNametextBox
            // 
            this.SecondNametextBox.Location = new System.Drawing.Point(182, 102);
            this.SecondNametextBox.Name = "SecondNametextBox";
            this.SecondNametextBox.Size = new System.Drawing.Size(137, 22);
            this.SecondNametextBox.TabIndex = 9;
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(25, 102);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(137, 22);
            this.FirstNametextBox.TabIndex = 8;
            // 
            // Yearslabel
            // 
            this.Yearslabel.AutoSize = true;
            this.Yearslabel.Location = new System.Drawing.Point(106, 287);
            this.Yearslabel.Name = "Yearslabel";
            this.Yearslabel.Size = new System.Drawing.Size(40, 16);
            this.Yearslabel.TabIndex = 7;
            this.Yearslabel.Text = "Edad";
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.AutoSize = true;
            this.FirstNamelabel.Location = new System.Drawing.Point(31, 141);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(69, 16);
            this.FirstNamelabel.TabIndex = 6;
            this.FirstNamelabel.Text = "A. Paterno";
            // 
            // SecondNamelabel
            // 
            this.SecondNamelabel.AutoSize = true;
            this.SecondNamelabel.Location = new System.Drawing.Point(203, 141);
            this.SecondNamelabel.Name = "SecondNamelabel";
            this.SecondNamelabel.Size = new System.Drawing.Size(71, 16);
            this.SecondNamelabel.TabIndex = 5;
            this.SecondNamelabel.Text = "A, Materno";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(352, 141);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(63, 16);
            this.Namelabel.TabIndex = 4;
            this.Namelabel.Text = "Nombres";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(457, 342);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(96, 39);
            this.Addbutton.TabIndex = 2;
            this.Addbutton.Text = "Añadir";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.Controls.Add(this.Deletebutton);
            this.tabPage2.Controls.Add(this.Editbutton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Sector2comboBox);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sectores";
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(463, 474);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(96, 39);
            this.Deletebutton.TabIndex = 5;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.UseVisualStyleBackColor = true;
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(19, 474);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(96, 39);
            this.Editbutton.TabIndex = 4;
            this.Editbutton.Text = "Actualizar";
            this.Editbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sector:";
            // 
            // Sector2comboBox
            // 
            this.Sector2comboBox.FormattingEnabled = true;
            this.Sector2comboBox.Location = new System.Drawing.Point(19, 47);
            this.Sector2comboBox.Name = "Sector2comboBox";
            this.Sector2comboBox.Size = new System.Drawing.Size(141, 24);
            this.Sector2comboBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(580, 569);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Label SecondNamelabel;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.Label Yearslabel;
        private System.Windows.Forms.TextBox NameCompletetextBox;
        private System.Windows.Forms.TextBox SecondNametextBox;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.ComboBox SectorcomboBox;
        private System.Windows.Forms.ComboBox Sector2comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Editbutton;
    }
}

