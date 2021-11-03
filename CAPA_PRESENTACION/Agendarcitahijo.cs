using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;



namespace CAPA_PRESENTACION
{
    public partial class Agendarcitahijo : Form
    {
        public Agendarcitahijo()
        {
            InitializeComponent();
        }

        private void Agendarcitahijo_Load(object sender, EventArgs e)
        {
            for (int f = 1; f <= 96; f++)
            {
                dtacita.Rows.Add();
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
                DateTime fecha = DateTime.Today;
                for (int f = 1; f <= 96; f++)
                {
                    archivo1.WriteLine(fecha.ToString("HH:mm"));
                    archivo1.WriteLine("");
                    fecha = fecha.AddMinutes(15);
                }
                archivo1.Close();
            }
            StreamReader archivo3 = new StreamReader(fechacita);
            int x = 0;
            while (!archivo3.EndOfStream)
            {
                string linea1 = archivo3.ReadLine();
                string linea2 = archivo3.ReadLine();
                dtacita.Rows[x].Cells[0].Value = linea1;
                dtacita.Rows[x].Cells[1].Value = linea2;

                x++;
            }
            archivo3.Close();
        }




        private void Calendaragenda_DateChanged(object sender, DateRangeEventArgs e)
        {
            Cargarfecha2();
        }

        private void dtacita_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DateTime select = Calendaragenda.SelectionStart;
            string fechacita = select.Year.ToString() + select.Month.ToString() + select.Day.ToString();
          StreamWriter archivo1 = new StreamWriter(fechacita);
            
            for (int f=0;f<dtacita.Rows.Count;f++)
            {
                archivo1.WriteLine(dtacita.Rows[f].Cells[0].Value.ToString());
                if (dtacita.Rows[f].Cells[1].Value != null)
                    archivo1.WriteLine(dtacita.Rows[f].Cells[1].Value.ToString());
                else
                    archivo1.WriteLine("");

            }

            archivo1.Close();


        }

        private void buttonpersolizado1_Click(object sender, EventArgs e)
        {
            Agendarcita agen = new Agendarcita();
            AddOwnedForm(agen);
            agen.Show();
        }

        private void textcodigo__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtacita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
