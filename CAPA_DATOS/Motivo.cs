using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class Motivo
    {
        int Id_Motivo;
        string Descripcion;

        public Motivo()
        {
        }

        public Motivo(int id_Motivo1, string descripcion1)
        {
            Id_Motivo1 = id_Motivo1;
            Descripcion1 = descripcion1;
        }

        public int Id_Motivo1 { get => Id_Motivo; set => Id_Motivo = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }

        public DataTable MostraMotivo()
        {
            DataTable Motiv = new DataTable("cita");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_mostrarmotivo = new SqlCommand();
                sp_mostrarmotivo.Connection = Conectar;
                sp_mostrarmotivo.CommandText = "psci.SP_MostrarMotivo";
                sp_mostrarmotivo.CommandType = CommandType.StoredProcedure;




                SqlDataAdapter adartar = new SqlDataAdapter(sp_mostrarmotivo);
                adartar.Fill(Motiv);



                if (sp_mostrarmotivo.ExecuteNonQuery() == 1)
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
            return Motiv;
        }

        public string insertarMotivo(Motivo motivo)
        {
            string retorno="";
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conet.cnx;
                connection.Open();

                SqlCommand sql = new SqlCommand();
                sql.Connection = connection;
                sql.CommandText = "psci.SP_NewMotivo";
                sql.CommandType = CommandType.StoredProcedure;

                SqlParameter MOTIVO = new SqlParameter();
                MOTIVO.ParameterName = "@Motivo";
                MOTIVO.SqlDbType = SqlDbType.NVarChar;
                MOTIVO.Value = motivo.Descripcion1;
                sql.Parameters.Add(MOTIVO);
                if (sql.ExecuteNonQuery() == 0)
                {
                    retorno = "Houston I have a problem";
                }
                else
                {
                    retorno = "Everything its ok";
                }
            }
            catch(Exception e)
            {
                retorno = e.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return retorno;
        }
    }
}
