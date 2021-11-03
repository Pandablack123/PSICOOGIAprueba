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
    public partial class RptExpe : Form
    {
        public RptExpe()
        {
            InitializeComponent();
        }

        private void RptExpe_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PYA2021DataSet23.RptExp' Puede moverla o quitarla según sea necesario.
            //this.RptExpTableAdapter.Fill(this.PYA2021DataSet23.RptExp);
            // TODO: esta línea de código carga datos en la tabla 'PYA2021DataSet23.RptExp' Puede moverla o quitarla según sea necesario.
            //this.RptExpTableAdapter.Fill(this.PYA2021DataSet23.RptExp);
            // TODO: esta línea de código carga datos en la tabla 'PYA2021DataSet.RptExp' Puede moverla o quitarla según sea necesario.
            //this.RptExpTableAdapter.Fill(this.PYA2021DataSet.RptExp,);
            iniciarReportes(textBox1.Text);

            this.reportViewer1.RefreshReport();
        }

        private void iniciarReportes(string val)
        {
            RptExpBindingSource.DataSource = Nexpediente.ReporteExp(val);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            iniciarReportes(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciarReportes(textBox1.Text);
        }
    }
}
