using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;



namespace CAPA_NEGOCIO
{
    public class ESTA2_1
    {

        public static DataTable ReporteG(DateTime fecha, DateTime fecha2 , int grado)
        {
            return new esta2().Reportegrado(fecha,fecha2,grado);
        }

        public static DataTable ReporteS(DateTime fecha, DateTime fecha2, string sexo)
        {
            return new esta2().Reportesexo(fecha, fecha2,sexo);
        }

        public static DataTable ReporteE(DateTime fecha, DateTime fecha2, int edad)
        {
            return new esta2().Reporteedad(fecha, fecha2, edad);
        }


        public static DataTable ReporteM(DateTime fecha, DateTime fecha2, string MOTI)
        {
            return new esta2().ReporteMotivo(fecha, fecha2, MOTI);
        }













    }
}
