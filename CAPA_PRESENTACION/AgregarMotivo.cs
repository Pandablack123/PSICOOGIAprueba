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
    public partial class AgregarMotivo : Form
    {
        public AgregarMotivo()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Nmotivo nmotivo = new Nmotivo();
            string result= nmotivo.InsertarMotivo(MotivoNom.Text);
            MessageBox.Show(result);
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
