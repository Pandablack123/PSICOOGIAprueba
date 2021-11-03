using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using System.Data;


namespace CAPA_NEGOCIO
{
   public class dINFORMEA
    {

        public static DataTable ReporteG(DateTime fecha, DateTime fecha2, int grado)
        {
            return new INFORMEa().Reportegrado(fecha, fecha2, grado);
        }

        public static DataTable ReporteS(DateTime fecha, DateTime fecha2, string sexo)
        {
            return new INFORMEa().Reportesexo(fecha, fecha2, sexo);
        }

        public static DataTable ReporteE(DateTime fecha, DateTime fecha2, int edad)
        {
            return new INFORMEa().Reporteedad(fecha, fecha2, edad);
        }


        public static DataTable ReporteM(DateTime fecha, DateTime fecha2, string MOTI)
        {
            return new INFORMEa().ReporteMotivo(fecha, fecha2, MOTI);
        }


















    }
}
