using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class Temas : Form
    {

        private string tema;

       

        public string Tema { get { return combobox1.Texts; } }
        string te;

        public Temas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void combobox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            combobox1.Texts = combobox1.SelectedItem.ToString();
        }

        private void buttonpersolizado1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
