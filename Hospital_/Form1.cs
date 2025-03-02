using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxs();
            //FirstNametextBox.KeyPress += seeDatas;
        }
        #region Variables_Globales

        string _select = "SELECCIONAR";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        string _entradaCadena;

        #endregion

        #region Constructores 

        public Form1(string _firstName, string _secondName, string _completeName, int age)
        {
            FirstName = _firstName;
            LastName = _secondName;
            Name = _completeName;
            Age = age;
        }

        #endregion
        #region Metodos

        public void ComboBoxs()
        {
            List<ComboBox> allComboBox = new List<ComboBox>() { SectorcomboBox, Sector2comboBox };
            List<string> Sector = new List<string>() { "SECTOR 1", "SECTOR 2", "SECTOR 3" };

            foreach (ComboBox comBox in allComboBox)
            {
                SectorcomboBox.Text = _select;
                Sector2comboBox.Text = _select;
                comBox.DropDownStyle = ComboBoxStyle.DropDownList;
                Sector.ForEach(value => comBox.Items.Add(value));
            }
        }

        //public void seeDatas(object sender, KeyPressEventArgs e)
        //{
        //    Form1 paciente = new Form1();
        //    paciente.FirstName = FirstNametextBox.Text;

        //    if (e.KeyChar == (char)(Keys.Enter))
        //    {
        //        label4.Text = paciente.FirstName;

        //    }
        //}

        #endregion

        #region Eventos

        private void Addbutton_Click(object sender, EventArgs e)
        {
            //if (FirstNametextBox.Text == string.Empty)
            //{
            //    MessageBox.Show("LA CADENA ESTA VACÍA ESCRIBA ALGO");

            //}
            //else
            //    MessageBox.Show(paciente.FirstName);
                
        }

        #endregion

    }
}
