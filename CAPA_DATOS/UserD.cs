using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class UserD
    {
        string Nombre;
        string Contraseña;

        public UserD() {}

        public UserD(string nombre1, string contraseña1)
        {
            Nombre1 = nombre1;
            Contraseña1 = contraseña1;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }

        public DataTable showU()
        {

            DataTable showuser = new DataTable("user");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_Newuser = new SqlCommand();
                sp_Newuser.Connection = Conectar;
                sp_Newuser.CommandText = "psci.ShowU";
                sp_Newuser.CommandType = CommandType.StoredProcedure;




                SqlDataAdapter adartar = new SqlDataAdapter(sp_Newuser);
                adartar.Fill(showuser);



                if (sp_Newuser.ExecuteNonQuery() == 1)
                {
                    retorno = "Everything it's ok";
                }
                else
                {
                    retorno = "Houston tenemos un problema";
                }

            }
            catch (Exception e)
            {
                retorno = e.Message;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showuser;


        }




    }
}
