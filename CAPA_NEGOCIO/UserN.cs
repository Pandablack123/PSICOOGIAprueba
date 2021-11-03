using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;


namespace CAPA_NEGOCIO
{
    public class UserN
    {
        public static DataTable showU()
        {
            DataTable tableu = new DataTable();
            UserD datos = new UserD();
            tableu = datos.showU();
            return tableu;
        }
    }
}
