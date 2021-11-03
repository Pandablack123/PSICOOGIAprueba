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
using Word = Microsoft.Office.Interop.Word;

namespace CAPA_PRESENTACION
{
    public partial class IniciarConsulta : Form
    {
        public IniciarConsulta()
        {
            InitializeComponent();
        }

        CitaN dto = new CitaN();

        private void button1_Click(object sender, EventArgs e)
        {
            bunifuShadowPanel1.Visible = true;
            dtaexpe.DataSource = dto.buscarcitas(textBox1.Text);
           
            //dtaexpe.Visible = true;
        }


        private void dtaexpe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuShadowPanel1.Visible = false;
            bunifuShadowPanel2.Visible = true;
            lblnombre.Text = dtaexpe.CurrentRow.Cells["Nombre"].Value.ToString();
            lblid.Text = dtaexpe.CurrentRow.Cells["ID_Cita"].Value.ToString();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string tipo;
            if (rbtnpadre.Checked == true)
            {
                tipo = bunifuLabel3.Text;
            }
            else if (rbtnestudiante.Checked == true)
            {
                tipo = bunifuLabel4.Text;
            }
            else
            {
                tipo = bunifuLabel5.Text;
            }
            ConsultaN consultaN = new ConsultaN();
            consultaN.insertconsulta(Convert.ToInt32(lblid.Text), txtactiviadades.Texts, txtobservaciones.Texts, tipo);
            //object objmiss = System.Reflection.Missing.Value;
            ////Word.Application objword = new Word.Application();
            //Word.Document objdoc = objword.Documents.Add(ref objmiss, ref objmiss, ref objmiss, ref objmiss);
            //objdoc.Activate();
            //objword.Selection.TypeText(txtinforme.Text);
            //objword.Visible = true;
            limpiar();
        }

        void limpiar()
        {
            txtactiviadades.Texts = "";
            txtobservaciones.Texts = "";
            txtinforme.Texts = "";
            rbtnestudiante.Checked = true;
            lblid.Text = "";
            lblnombre.Text = "";
            bunifuShadowPanel2.Visible = false;
            bunifuShadowPanel1.Visible = true;
;        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de cancelar?\nSi cancelas no se guardaran los datos", "Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                bunifuShadowPanel2.Visible = false;
                limpiar();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            limpiar();
        }
    }
}
