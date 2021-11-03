using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CAPA_DATOS.usercache;
using CAPA_DATOS.ServidorCorreo;




namespace CAPA_DATOS
{
    public class DLogin
    {
        string nombre;
        string contraseña;
        string camcontra;
       


        public DLogin()
        {
        }

        public DLogin(string nombre, string contraseña , string cacontra)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            Camcontra = cacontra;
           

            
        }
            

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Camcontra { get => camcontra; set => camcontra = value; }
     

        public string INICIO(DLogin sesion)
        {
            string retorno = "";
            SqlConnection conectar = new SqlConnection();
            try
            {
                conectar.ConnectionString = Conet.cnx;
                conectar.Open();

                SqlCommand splogin = new SqlCommand();
                splogin.Connection = conectar;
                splogin.CommandText = "psci.ShowU";
                splogin.CommandType = CommandType.StoredProcedure;

                SqlParameter nom = new SqlParameter();
                nom.ParameterName = "@Nombre";
                nom.SqlDbType = SqlDbType.NVarChar;
                nom.Value = sesion.Nombre;
                splogin.Parameters.Add(nom);

                SqlParameter con = new SqlParameter();
                con.ParameterName = "@Contraseña";
                con.SqlDbType = SqlDbType.NChar;
                con.Value = sesion.Contraseña;
                splogin.Parameters.Add(con);

                SqlDataReader sqlDataReader = splogin.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    retorno = "Everithing its ok";
                    while (sqlDataReader.Read())
                    {
                        USERcache.Nombre = sesion.Nombre;
                        USERcache.Contraseña = sesion.Contraseña;
                    }
                    
                }
                else
                {
                    retorno = "you have a problem";
                }
            }
            catch (Exception e)
            {
                retorno=e.Message;
            }
            finally
            {
                conectar.Close();
            }
           
           

            return retorno;
        }

        public string Cpassword(DLogin cambio)
        {

            string retorno = "";
            SqlConnection conectar = new SqlConnection();
            try
            {
                conectar.ConnectionString = Conet.cnx;
                conectar.Open();

                SqlCommand splogin = new SqlCommand();
                splogin.Connection = conectar;
                splogin.CommandText = "psci.SP_CambiarContr";
                splogin.CommandType = CommandType.StoredProcedure;

                SqlParameter nom = new SqlParameter();
                nom.ParameterName = "@Nombre";
                nom.SqlDbType = SqlDbType.NVarChar;
                nom.Value = cambio.Nombre;
                splogin.Parameters.Add(nom);

                SqlParameter con = new SqlParameter();
                con.ParameterName = "@contraanti";
                con.SqlDbType = SqlDbType.NChar;
                con.Value = cambio.Contraseña;
                splogin.Parameters.Add(con);

                SqlParameter cons = new SqlParameter();
                cons.ParameterName = "@contra";
                cons.SqlDbType = SqlDbType.NChar;
                cons.Value = cambio.Camcontra;
                splogin.Parameters.Add(cons);

                SqlDataReader sqlDataReader = splogin.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    retorno = "Everithing its ok";

                }
                else
                {
                    retorno = "you have a problem";
                }
            }
            catch (Exception e)
            {
                retorno = e.Message;
            }
            finally
            {
                conectar.Close();
            }

            return retorno;

        }

        public string recovery(DLogin recor)
        {
            string retorno = "";
            SqlConnection conectar = new SqlConnection();

           
            try
            {
                conectar.ConnectionString = Conet.cnx;
                conectar.Open();

                SqlCommand splogin = new SqlCommand();
                splogin.Connection = conectar;
                splogin.CommandText = "SELECT * from [psci].[User] where Nombre=@nombre";
                splogin.CommandType = CommandType.Text;

                SqlParameter nom = new SqlParameter();
                nom.ParameterName = "@nombre";
                nom.SqlDbType = SqlDbType.NVarChar;
                nom.Value = recor.Nombre;
                splogin.Parameters.Add(nom);



                

                SqlDataReader sqlDataReader = splogin.ExecuteReader();

                if (sqlDataReader.Read()==true)
                {
                    retorno = "Everithing its ok";
                    string usernombre = sqlDataReader.GetString(0);
                    string usercontra = sqlDataReader.GetString(1);
                    string accountpassword = sqlDataReader.GetString(2);

                    var mailservice =new  ServidorCorreo.SystemSuportMail();
                    mailservice.sendMail(
                        subject: "System: Password recory request",
                        body: "Hola" + usernombre + "\n" + "Su contraseña es: " + usercontra,
                        recipientMail: new List<string> { accountpassword }
                        );
                }
                else
                {
                    retorno = "you have a problem";
                }
            }
            catch (Exception e)
            {
                retorno = e.Message;
            }
            finally
            {
                conectar.Close();
            }

            return retorno;
        }

       
    }
}
