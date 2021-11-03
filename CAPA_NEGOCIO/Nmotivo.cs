using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_NEGOCIO
{
   public class Nmotivo
    {
        public DataTable Mostarmotivo()
        {
            Motivo motivo = new Motivo();

            DataTable data = new DataTable();
            data = motivo.MostraMotivo();
            return data;
        }

        public string InsertarMotivo(string Motivodesc)
        {
            Motivo motivo = new Motivo();
            motivo.Descripcion1 = Motivodesc;

            return motivo.insertarMotivo(motivo);

        }
    }
}
