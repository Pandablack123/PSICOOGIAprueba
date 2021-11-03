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
    public partial class VerConsulta : Form
    {
        public VerConsulta()
        {
            InitializeComponent();
        }

        ConsultaN consulta = new ConsultaN();
        private void button1_Click(object sender, EventArgs e)
        {

            bunifuDataGridView1.DataSource = consulta.buscarconsulta(textver.Text);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
