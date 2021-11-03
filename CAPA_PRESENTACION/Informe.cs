using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;*/
using Microsoft.Reporting.WinForms;
using CAPA_NEGOCIO;


namespace CAPA_PRESENTACION
{
    public partial class Graficos : Form
    {
        public Graficos()
        {
            InitializeComponent();
        }
        bool nombre1;
        private void Graficos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();


        }

        string tipo;

        private void IniciarReporte(DateTime fecha,DateTime fecha2)
        {
            //reportViewer1.DataBindings.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localR = reportViewer1.LocalReport;
            localR.DataSources.Clear();




            if (tipo=="grado")
            {

                ReportDataSource RDS = new ReportDataSource("GRADO",Destadistica.showest(fecha,fecha2));
                localR.ReportPath = "D:\\Users\\jeffry\\source\\repos\\PSICOOGIAprueba\\CAPA_PRESENTACION\\grado.rdlc";
                                  //  D: \Users\jeffry\source\repos\PSICOOGIAprueba\CAPA_PRESENTACION
                localR.DataSources.Clear();
                localR.DataSources.Add(RDS);
                localR.Refresh();
            }


            if (tipo=="sexo")
            {

                ReportDataSource RDS = new ReportDataSource("Sexo", Destadistica.showestS(fecha, fecha2));
                localR.ReportPath = "D:\\Users\\jeffry\\source\\repos\\PSICOOGIAprueba\\CAPA_PRESENTACION\\SEXO.rdlc";
                //  D: \Users\jeffry\source\repos\PSICOOGIAprueba\CAPA_PRESENTACION
                localR.DataSources.Clear();
                localR.DataSources.Add(RDS);
                localR.Refresh();
            }

            if (tipo=="edad")
            {

                ReportDataSource RDS = new ReportDataSource("edad", Destadistica.showestE(fecha, fecha2));
                localR.ReportPath = "D:\\Users\\jeffry\\source\\repos\\PSICOOGIAprueba\\CAPA_PRESENTACION\\edad1.rdlc";
                //  D: \Users\jeffry\source\repos\PSICOOGIAprueba\CAPA_PRESENTACION
                localR.DataSources.Clear();
                localR.DataSources.Add(RDS);
                localR.Refresh();
            }

            if (tipo=="motivo")
            {

                ReportDataSource RDS = new ReportDataSource("MOTIVO", Destadistica.showestM(fecha, fecha2));
                localR.ReportPath = "D:\\Users\\jeffry\\source\\repos\\PSICOOGIAprueba\\CAPA_PRESENTACION\\MOTIVO.rdlc";
                //  D: \Users\jeffry\source\repos\PSICOOGIAprueba\CAPA_PRESENTACION
                localR.DataSources.Clear();
                localR.DataSources.Add(RDS);
                localR.Refresh();
            }


            







            this.reportViewer1.RefreshReport();
        }


        private void IniciarReporte1(DateTime fecha, DateTime fecha2, string nombre)
        {
            //reportViewer1.DataBindings.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localR = reportViewer1.LocalReport;
            localR.DataSources.Clear();




            if (nombre1 == true)
            {

                ReportDataSource RDS = new ReportDataSource("Nombre", Destadistica.showestN(fecha, fecha2,nombre));
                localR.ReportPath = "D:\\Users\\jeffry\\source\\repos\\PSICOOGIAprueba\\CAPA_PRESENTACION\\NOMBRE.rdlc";
                //  D: \Users\jeffry\source\repos\PSICOOGIAprueba\CAPA_PRESENTACION
                localR.DataSources.Clear();
                localR.DataSources.Add(RDS);
                localR.Refresh();
            }




            this.reportViewer1.RefreshReport();
        }




        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        

      

        private void grado_Click(object sender, EventArgs e)
        {
            tipo = "grado";
            text.Enabled = false;
            
        }

        private void seooo_Click(object sender, EventArgs e)
        {
            tipo = "sexo";
            text.Enabled = false;
        }

        private void edad_Click(object sender, EventArgs e)
        {
            
            
                tipo = "edad";
                text.Enabled = false;
            
           
        }

        private void motivo_Click(object sender, EventArgs e)
        {
            tipo = "motivo";
        }

        private void nombre_Click(object sender, EventArgs e)
        {
            
            IniciarReporte1(fecha1.Value, fecha2.Value,text.Text);
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            if (bunifuRadioButton1.Checked == true)
            {
                IniciarReporte1(fecha1.Value, fecha2.Value, text.Text);
            }
            else
            {
                IniciarReporte(fecha1.Value, fecha2.Value);
            }
          
        }

        private void bunifuRadioButton1_Click(object sender, EventArgs e)
        {
            nombre1 = true;
            bunifuLabel3.Visible = true;
            text.Visible = true;
        }
    }
}
