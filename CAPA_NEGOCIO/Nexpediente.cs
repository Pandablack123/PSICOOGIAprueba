using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;


namespace CAPA_NEGOCIO
{
    public class Nexpediente
    {

        public string insertexpediente(int idre,int id,string nombre, string estado, byte[] foto, string no_expe)
        {

            Dexpediente datos = new Dexpediente();
            datos.ID_Remision1 = idre;
            datos.ID_Expediente1 = id;
            datos.Nombre1 = nombre;
            datos.Estado1 = estado;
            datos.Foto1 = foto;
            datos.Noexpediente1 = no_expe;
            

            return datos.insertexpediente(datos);


        }

        public string UpdateDexpediente(int id ,byte[] foto)
        {

            Dexpediente datos = new Dexpediente();
            datos.ID_Expediente1 = id;
            datos.Foto1 = foto;
            

            return datos.UpdateDexpediente(datos);


        }

        public  DataTable showEX()
        {
            DataTable tabla = new DataTable();
            Dexpediente datos = new Dexpediente();
            tabla = datos.showEX();
            return tabla;
            
        }

        public DataTable buscarexpediente( string nombre)
        {
            DataTable table = new DataTable();
            Dexpediente datos = new Dexpediente();
            datos.Nombre1 = nombre;
            table = datos.buscarexpediente(datos);
            return table;

        }

        /* Método para traer datos para el reporte de expedientes filtrado por nombre*/
        public static DataTable ReporteExp(string valor)
        {
            return new Dexpediente().ReporteExpediente(valor);
        }

        public DataTable buscarexpedientecita(string nombre)
        {
            DataTable table = new DataTable();
            Dexpediente datos = new Dexpediente();
            datos.Nombre1 = nombre;
            table = datos.buscarexpedientecita(datos);
            return table;

        }

        public string Baja(int ID, string estado)
        {
            Dexpediente datos = new Dexpediente();
            datos.ID_Expediente1 = ID;
            datos.Estado1 = estado;
           return datos.baja(datos);
        }

        public DataTable mostrarfoto(int id)
        {
            DataTable tabla = new DataTable();
            Dexpediente datos = new Dexpediente();
            datos.ID_Expediente1 = id;
            tabla =datos.mostrarfoto(datos);
            return tabla;
        }

        public DataTable mostrarestu(string estu)
        {
            DataTable tabla = new DataTable();
            Dexpediente datos = new Dexpediente();
            datos.Estu = estu;
            tabla = datos.buscarestudiante(datos);
            return tabla;
        }


    }
}
