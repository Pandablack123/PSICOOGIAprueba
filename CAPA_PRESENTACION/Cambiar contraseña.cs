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
    public partial class Cambiar_contraseña : Form
    {
        public Cambiar_contraseña()
        {
            InitializeComponent();
        }
        NLogin login = new NLogin();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnccon_Click(object sender, EventArgs e)
        {
            
            string me = login.anymetothcon(txtacon.Texts);
            string nom = login.anymetoth();

            if (me == "ok")
            {
                if (txtncon.Texts == txtconfcon.Texts)
                {
                    login.cambiopassword(nom, txtacon.Texts, txtncon.Texts);
                    MessageBox.Show("Se cambio contraseña sactifactoriamente");
                    this.Close();
                }
                else
                {
                    txtncon.BorderColor = Color.Red;
                    txtconfcon.BorderColor = Color.Red;
                    MessageBox.Show("No coinciden");
                }
               
            }
            else
            {
                MessageBox.Show("Contraseña actual incorrecta");
                txtacon.BorderColor = Color.Red;
            }
           

        }
    }
}
