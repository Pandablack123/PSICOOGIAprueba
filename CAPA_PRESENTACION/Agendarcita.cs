using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class Agendarcita : Form
    {
    
        public Agendarcita()
        {
            InitializeComponent();

        }

        Nexpediente data1 = new Nexpediente();
        CitaN ins = new CitaN();
      

        private void button1_Click(object sender, EventArgs e)
        {
            dtaagendar.DataSource= data1.buscarexpediente(textagendar.Text);
            dtaagendar.Columns[3].Visible = false;

            
        }

        private void dtaagendar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Agendarcita_Load(object sender, EventArgs e)
        {

            btnagen.Visible = false;
            for (int f = 1; f <= 12; f++)
            {
                dataGridView2.Rows.Add();
            }
            Cargarfecha2();
        }

        private void Cargarfecha2()
        {
            DateTime select = Calendaragenda.SelectionStart;
            Fechacita.Text = "Fecha selecionada:" + select.ToString("dd/MM/yy");
            string fechacita = select.Year.ToString() + select.Month.ToString() + select.Day.ToString();
            if (!File.Exists(fechacita))
            {
                StreamWriter archivo1 = new StreamWriter(fechacita);
                DateTime fecha = DateTime.Today.AddHours(8);
                for (int f = 1; f <= 11; f++)
                {
                    archivo1.WriteLine(fecha.ToString("HH:mm"));
                    archivo1.WriteLine("");
                    fecha = fecha.AddMinutes(45);
                }
                archivo1.Close();
            }
            StreamReader archivo3 = new StreamReader(fechacita);
            int x = 0;
            while (!archivo3.EndOfStream)
            {
                string linea1 = archivo3.ReadLine();
                string linea2 = archivo3.ReadLine();
                dataGridView2.Rows[x].Cells[0].Value = linea1;
                dataGridView2.Rows[x].Cells[1].Value = linea2;

                x++;
            }
            archivo3.Close();
        }


        
        private void buttonpersolizado1_Click(object sender, EventArgs e)
        {
            paneldegra22.Visible = false;
           
        }

        private void paneldegra21_Click(object sender, EventArgs e)
        {
            paneldegra21.Visible = true;
        }

       

        private void dtaagendar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textnombre.Texts = dtaagendar.CurrentRow.Cells["Nombre"].Value.ToString();
            textcodici.Texts = dtaagendar.CurrentRow.Cells["ID_Expediente"].Value.ToString();
            paneldegra22.Visible = true;
            buttonpersolizado1.Visible = false;
            btnagen.Visible = true;
        }

        private void buttonpersolizado2_Click(object sender, EventArgs e)
        {

        }

        private void btnagen_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtacita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Calendaragenda_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            Cargarfecha2();
        }

        private void btnagen_Click_1(object sender, EventArgs e)
        {
           // DataGridViewRow fila = new DataGridViewRow();
            //fila.CreateCells(dataGridView2);
          //  fila.Cells[1].Value = textnombre.Texts;
            dataGridView2.CurrentRow.Cells[1].Value = textnombre.Texts;
           //buscra tabla procedimiento almacenado 
           //dataGridView2.Rows.Add(fi);
            textnombre.Texts = "";
            texthora.Text = "";
           
            texvalor.Text = Calendaragenda.SelectionStart.Day.ToString() + "/" + Calendaragenda.SelectionStart.Month.ToString() + "/" + Calendaragenda.SelectionStart.Year.ToString();
            texthora.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();



           // int ins;

            CitaN ins = new CitaN();
            //ins= CitaN.insertcita( Convert.ToChar( textcodigo.Texts), Convert.ToChar(textcodici.Texts), Convert.ToDateTime(texvalor.Text));
            //ins = CitaN.(Convert.ToInt32(textcodigo.Texts), Convert.ToInt32(textcodici.Texts), Convert.ToDateTime(texvalor.Text));
           int codigo = Convert.ToInt32(textcodici.Texts);
          //  int codigoci = Convert.ToInt32(textcodici.Texts);

            ins.insertcita(codigo,Convert.ToDateTime(texvalor.Text),Convert.ToDateTime(texthora.Text));

            MessageBox.Show("Se ha agendado exitosamente la cita");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void texvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtaagendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void paneldegra21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneldegra21_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void paneldegra22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelagenda_Paint(object sender, PaintEventArgs e)
        {

        }













        /*   private void dtaagendar_CellClick(object sender, DataGridViewCellEventArgs e)
           {
               this.Hide();
               Agendarcitahijo agen = new Agendarcitahijo();
               agen.ShowDialog();
           }*/

        /* private void btnagendar_Click(object sender, EventArgs e)
         {
             Agendarcitahijo agend = Owner as Agendarcitahijo;
             //agend.textcodigo.text =  
         }*/





    }
}
