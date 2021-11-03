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
    public partial class Actualizar_formulario : Form
    {
        public Actualizar_formulario()
        {
            InitializeComponent();
        }

        SeguimientoN seguimiento = new SeguimientoN();
        private void Actualizar_formulario_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = seguimiento.showS();
        }

        private void bunifuDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblidsegui.Text = bunifuDataGridView1.CurrentRow.Cells["ID_Seguimiento"].Value.ToString();
            textboxpersonal1.Texts= bunifuDataGridView1.CurrentRow.Cells["Observaciones"].Value.ToString();
            bunifuLabel1.Text= bunifuDataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            bunifuShadowPanel1.Visible = true;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            SeguimientoN seguimiento = new SeguimientoN();
            seguimiento.updateseguimientoO(Convert.ToInt32(lblidsegui.Text), textboxpersonal1.Texts);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void limpiar()
        {
            lblidsegui.Text = "";
            textboxpersonal1.Texts = "";
            bunifuLabel1.Text = "";
        }
    }
}
