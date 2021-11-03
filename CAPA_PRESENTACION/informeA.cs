using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CAPA_NEGOCIO;


namespace CAPA_PRESENTACION
{
    public partial class informeA : Form
    {
        public informeA()
        {
            InitializeComponent();
        }

        private void informeA_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        bool grado2;
        bool edad2;
        bool SEXO1;
        bool MoTI;

        private void IniciarReporte(DateTime fecha, DateTime fecha2, int grado3)
        {
            //reportViewer1.DataBindings.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localR = reportViewer1.LocalReport;
            localR.DataSources.Clear();




            if (grado2 == true)
            {

                ReportDataSource RDS = new ReportDataSource("gradoA", dINFORMEA.ReporteG(fecha, fecha2, grado3));
                localR.ReportPath = "D:\\Users\\jeffry\\source\\repos\\PSICOOGIAprueba\\CAPA_PRESENTACION\\REPORTEA\\grado2.rdlc";
                //  D: \Users\jeffry\source\repos\PSICOOGIAprueba\CAPA_PRESENTACION
                localR.DataSources.Clear();
                localR.DataSources.Add(RDS);
                localR.Refresh();
            }
            this.reportViewer1.RefreshReport();





        }


        private void IniciarReporte1(DateTime fecha, DateTime fecha2, String SEXO)
        {
            //reportViewer1.DataBindings.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localR = reportViewer1.LocalReport;
            localR.DataSources.Clear();




            if (SEXO1 == true)
            {

                ReportDataSource RDS = new ReportDataSource("sexoA", dINFORMEA.ReporteS(fecha, fecha2, SEXO));
                localR.ReportPath = "D:\\Users\\jeffry\\source\\repos\\PSICOOGIAprueba\\CAPA_PRESENTACION\\REPORTEA\\sexo2.rdlc";
                //  D: \Users\jeffry\source\repos\PSICOOGIAprueba\CAPA_PRESENTACION
                localR.DataSources.Clear();
                localR.DataSources.Add(RDS);
                localR.Refresh();
            }

            this.reportViewer1.RefreshReport();




        }



        private void IniciarReporte2(DateTime fecha, DateTime fecha2, int edad1)
        {
            //reportViewer1.DataBindings.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localR = reportViewer1.LocalReport;
            localR.DataSources.Clear();




            if (edad2 == true)
            {

                ReportDataSource RDS = new ReportDataSource("edadA", dINFORMEA.ReporteE(fecha, fecha2, edad1));
                localR.ReportPath = "D:\\Users\\jeffry\\source\\repos\\PSICOOGIAprueba\\CAPA_PRESENTACION\\REPORTEA\\edad2.rdlc";
                //  D: \Users\jeffry\source\repos\PSICOOGIAprueba\CAPA_PRESENTACION
                localR.DataSources.Clear();
                localR.DataSources.Add(RDS);
                localR.Refresh();
            }

            this.reportViewer1.RefreshReport();




        }


        private void IniciarReporte3(DateTime fecha, DateTime fecha2, string motivo)
        {
            //reportViewer1.DataBindings.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localR = reportViewer1.LocalReport;
            localR.DataSources.Clear();




            if (MoTI == true)
            {

                ReportDataSource RDS = new ReportDataSource("motiA", dINFORMEA.ReporteM(fecha, fecha2, motivo));
                localR.ReportPath = "D:\\Users\\jeffry\\source\\repos\\PSICOOGIAprueba\\CAPA_PRESENTACION\\REPORTEA\\motivo2.rdlc";
                //  D: \Users\jeffry\source\repos\PSICOOGIAprueba\CAPA_PRESENTACION
                localR.DataSources.Clear();
                localR.DataSources.Add(RDS);
                localR.Refresh();
            }

            this.reportViewer1.RefreshReport();




        }






       
      
        

       

        private void grado_Click_1(object sender, EventArgs e)
        {
            grado2 = true;

            IniciarReporte(fecha.Value, fecha2.Value, Convert.ToInt32(TextBox1.Text));
        }

        private void sexoo_Click_1(object sender, EventArgs e)
        {
            SEXO1 = true;
            IniciarReporte1(fecha.Value, fecha2.Value, TextBox1.Text);
        }

        private void edad_Click_1(object sender, EventArgs e)
        {
            edad2 = true;
            IniciarReporte2(fecha.Value, fecha2.Value, Convert.ToInt32(TextBox1.Text));
        }

        private void moti_Click_1(object sender, EventArgs e)
        {
            MoTI = true;
            IniciarReporte3(fecha.Value, fecha2.Value, TextBox1.Text);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}






