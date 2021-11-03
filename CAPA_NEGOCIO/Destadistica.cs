using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;


namespace CAPA_NEGOCIO
{
    public class Destadistica
    {

        public static DataTable showest(DateTime fecha, DateTime fecha2)
        {
            estadistica estadistica = new estadistica();
            estadistica.Fecha = fecha;
            estadistica.Fecha2 = fecha2;
            DataTable data = new DataTable();
            data = estadistica.showestad(estadistica);
            return data;


        }


        public static DataTable showestS(DateTime fecha, DateTime fecha2)
        {
            estadistica estadistica1 = new estadistica();
            estadistica1.Fecha = fecha;
            estadistica1.Fecha2 = fecha2;
            DataTable data = new DataTable();
            data = estadistica1.showestadS(estadistica1);
            return data;


        }

        public static DataTable showestE(DateTime fecha, DateTime fecha2)
        {
            estadistica estadistica2 = new estadistica();
            estadistica2.Fecha = fecha;
            estadistica2.Fecha2 = fecha2;
            DataTable data = new DataTable();
            data = estadistica2.showestadE(estadistica2);
            return data;


        }

        public static DataTable showestM(DateTime fecha, DateTime fecha2)
        {
            estadistica estadistica3 = new estadistica();
            estadistica3.Fecha = fecha;
            estadistica3.Fecha2 = fecha2;
            DataTable data = new DataTable();
            data = estadistica3.showestadM(estadistica3);
            return data;


        }



        public static DataTable showestN(DateTime fecha, DateTime fecha2,string nombre)
        {
            estadistica estadistica4 = new estadistica();
            estadistica4.Fecha = fecha;
            estadistica4.Fecha2 = fecha2;
            estadistica4.Nombre1 = nombre;
            DataTable data = new DataTable();
            data = estadistica4.showestadN(estadistica4);
            return data;


        }




    }
}
