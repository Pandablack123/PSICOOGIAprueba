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
    public partial class IniciarSeguimiento : Form
    {
        public IniciarSeguimiento()
        {
            InitializeComponent();
           
        }

        public IniciarSeguimiento(string idex)
        {
            Idex = idex;
        }

       

        public string Idex { get; set; }

        private void IniciarSeguimiento_Load(object sender, EventArgs e)
        {
            lblid.Text = this.Idex;
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
          
            SeguimientoN seguimientoN = new SeguimientoN();
            string fecha = DateTime.Now.ToString();
            DateTime date = bunifuDatePicker1.Value;
            seguimientoN.insertseguimiento(Convert.ToInt32(lblid.Text), Convert.ToDateTime(fecha), date, textboxpersonal1.Texts);
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            limpiar();
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de cancelar?\nSi cancelas no se guardara el periodo de seguimiento", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }

        private void limpiar()
        {
            lblid.Text = "";
            textboxpersonal1.Texts = "";
        }
    }
}
