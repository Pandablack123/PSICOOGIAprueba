using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class RemisionN
    {
        public string insertremision(int idrem,int id,string remitente, int motivoRemision, DateTime Fecha, string expe)
        {
            RemisionD datos = new RemisionD();
            datos.ID_Remision1 = idrem;
            datos.ID_Expediente2 = id;
            datos.Remitente1 = remitente;
            datos.MotivoRemision1 = motivoRemision;
            datos.Fecha = Fecha;
            datos.NoEXPE1 = expe;

            return datos.insertremision(datos);


        }

        public static string updateremision(int iD_Expediente, string remitente, int motivoRemision)
        {
            RemisionD datos = new RemisionD();
            
            datos.ID_Expediente2 = iD_Expediente;
            datos.Remitente1 = remitente;
            datos.MotivoRemision1 = motivoRemision;

            return datos.Updateremision(datos);


        }

        public static DataTable showR()
        {
            DataTable tableR = new DataTable();
            RemisionD datos = new RemisionD();
            tableR = datos.showR();
            return tableR;
        }
















    }
}
