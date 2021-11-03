using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class Recovery : Form
    {
        public Recovery()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var user = new NLogin();

            var reults=user.recory(bunifuTextBox1.Text);
            MessageBox.Show("Se envio un correo electronico con su contraseña \n Se le recomienda cambiar la contraseña");
           
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
