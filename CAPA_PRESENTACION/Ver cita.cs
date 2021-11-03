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
    public partial class Ver_cita : Form
    {
        public Ver_cita()
        {
            InitializeComponent();
        }

        CitaN datos = new CitaN();

        private void Ver_cita_Load(object sender, EventArgs e)
        {
            dtacita.DataSource = datos.showct();
            dtacita.Columns[0].Visible = false;
            dtacita.Columns[1].Visible = false;
            btnposponer.Enabled = false;

            cargarcita();
        }

        private void dtacita_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnposponer.Enabled = true;


            
            
            textidcita.Text = dtacita.CurrentRow.Cells["ID_Cita"].Value.ToString();
            textremision.Text = dtacita.CurrentRow.Cells["ID_Expediente"].Value.ToString();
            textfecha.Text = dtacita.CurrentRow.Cells["Fecha"].Value.ToString();
            texthoraA.Text = dtacita.CurrentRow.Cells["Hora"].Value.ToString();

            

        }

        private void dtacita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           cargarcita();
        }

        private void btnposponer_Click(object sender, EventArgs e)
        {
           texfecha2.Text= monthfechaactu.SelectionStart.Day.ToString() + "/" + monthfechaactu.SelectionStart.Month.ToString() + "/" + monthfechaactu.SelectionStart.Year.ToString();
            //monthfechaactu.SelectionStart = Convert.ToDateTime( texfecha2.Text);
            CitaN up = new CitaN();
            int cita = Convert.ToInt32(textidcita.Text);
            int remision = Convert.ToInt32(textremision.Text);

            up.updatecita(cita,remision,Convert.ToDateTime(texfecha2.Text),Convert.ToDateTime(texthoraA.Text));

           
            MessageBox.Show("Se ha actualizado exitosamente");

        }


        private void cargarcita()
        {


            DateTime select = monthfechaactu.SelectionStart;
            label3.Text = "Fecha selecionada:" + select.ToString("dd/MM/yy");
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
