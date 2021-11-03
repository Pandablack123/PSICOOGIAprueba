using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
   public class estadistica

    {

        DateTime fecha;
        DateTime fecha2;
        string Nombre;

        public estadistica()
        {
            
        }

        public estadistica(DateTime fecha, DateTime fecha2,string Nombre)
        {
            Fecha = fecha;
            Fecha2 = fecha2;
            Nombre = Nombre1;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Fecha2 { get => fecha2; set => fecha2 = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }

        public DataTable showestad(estadistica expe)
        {

            DataTable showesta = new DataTable("estadistica");
            
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_estadistica = new SqlCommand();
                sp_estadistica.Connection = Conectar;
                sp_estadistica.CommandText = "[psci].[SP_grados]";
                sp_estadistica.CommandType = CommandType.StoredProcedure;

                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                fecha.Value = expe.Fecha;
                sp_estadistica.Parameters.Add(fecha );

                SqlParameter fecha2 = new SqlParameter();
                fecha2.ParameterName = "@fecha2";
                fecha2.SqlDbType = SqlDbType.DateTime;
                fecha2.Value = expe.Fecha2;
                sp_estadistica.Parameters.Add(fecha2);



                SqlDataAdapter adartar = new SqlDataAdapter(sp_estadistica);
                adartar.Fill(showesta);

                /*

                if (sp_estadistica.ExecuteNonQuery() == 1)
                {
                    retorno = "Everything it's ok";
                }
                else
                {
                    retorno = "Houston tenemos un problema";
                }
                */
            }
            catch
            {
                showesta = null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showesta;


        }



        public DataTable showestadS(estadistica expeS)
        {

            DataTable showestaS = new DataTable("estadisticaS");

            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_estadistica = new SqlCommand();
                sp_estadistica.Connection = Conectar;
                sp_estadistica.CommandText = "[psci].[SP_sexo]";
                sp_estadistica.CommandType = CommandType.StoredProcedure;

                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                fecha.Value = expeS.Fecha;
                sp_estadistica.Parameters.Add(fecha);

                SqlParameter fecha2 = new SqlParameter();
                fecha2.ParameterName = "@fecha2";
                fecha2.SqlDbType = SqlDbType.DateTime;
                fecha2.Value = expeS.Fecha2;
                sp_estadistica.Parameters.Add(fecha2);



                SqlDataAdapter adartar = new SqlDataAdapter(sp_estadistica);
                adartar.Fill(showestaS);

                /*

                if (sp_estadistica.ExecuteNonQuery() == 1)
                {
                    retorno = "Everything it's ok";
                }
                else
                {
                    retorno = "Houston tenemos un problema";
                }
                */
            }
            catch
            {
                showestaS = null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showestaS;


        }


        public DataTable showestadE(estadistica expeE)
        {

            DataTable showestaE = new DataTable("estadisticaS");

            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_estadistica = new SqlCommand();
                sp_estadistica.Connection = Conectar;
                sp_estadistica.CommandText = "[psci].[SP_edad]";
                sp_estadistica.CommandType = CommandType.StoredProcedure;

                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                fecha.Value = expeE.Fecha;
                sp_estadistica.Parameters.Add(fecha);

                SqlParameter fecha2 = new SqlParameter();
                fecha2.ParameterName = "@fecha2";
                fecha2.SqlDbType = SqlDbType.DateTime;
                fecha2.Value = expeE.Fecha2;
                sp_estadistica.Parameters.Add(fecha2);



                SqlDataAdapter adartar = new SqlDataAdapter(sp_estadistica);
                adartar.Fill(showestaE);

                /*

                if (sp_estadistica.ExecuteNonQuery() == 1)
                {
                    retorno = "Everything it's ok";
                }
                else
                {
                    retorno = "Houston tenemos un problema";
                }
                */
            }
            catch
            {
                showestaE = null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showestaE;


        }

        public DataTable showestadM(estadistica expeE)
        {

            DataTable showestaM = new DataTable("estadisticaM");

            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_estadistica = new SqlCommand();
                sp_estadistica.Connection = Conectar;
                sp_estadistica.CommandText = "[psci].[SP_Moti]";
                sp_estadistica.CommandType = CommandType.StoredProcedure;

                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                fecha.Value = expeE.Fecha;
                sp_estadistica.Parameters.Add(fecha);

                SqlParameter fecha2 = new SqlParameter();
                fecha2.ParameterName = "@fecha2";
                fecha2.SqlDbType = SqlDbType.DateTime;
                fecha2.Value = expeE.Fecha2;
                sp_estadistica.Parameters.Add(fecha2);



                SqlDataAdapter adartar = new SqlDataAdapter(sp_estadistica);
                adartar.Fill(showestaM);

                /*

                if (sp_estadistica.ExecuteNonQuery() == 1)
                {
                    retorno = "Everything it's ok";
                }
                else
                {
                    retorno = "Houston tenemos un problema";
                }
                */
            }
            catch
            {
                showestaM = null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showestaM;


        }


        public DataTable showestadN(estadistica expeN)
        {

            DataTable showestaN = new DataTable("estadisticaM");

            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_estadistica = new SqlCommand();
                sp_estadistica.Connection = Conectar;
                sp_estadistica.CommandText = "[psci].[SP_nombreB]";
                sp_estadistica.CommandType = CommandType.StoredProcedure;

                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                fecha.Value = expeN.Fecha;
                sp_estadistica.Parameters.Add(fecha);

                SqlParameter fecha2 = new SqlParameter();
                fecha2.ParameterName = "@fecha2";
                fecha2.SqlDbType = SqlDbType.DateTime;
                fecha2.Value = expeN.Fecha2;
                sp_estadistica.Parameters.Add(fecha2);

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.NVarChar;
                nombre.Size = 50;
                nombre.Value = expeN.Nombre1;
                sp_estadistica.Parameters.Add(nombre);

                SqlDataAdapter adartar = new SqlDataAdapter(sp_estadistica);
                adartar.Fill(showestaN);

                /*

                if (sp_estadistica.ExecuteNonQuery() == 1)
                {
                    retorno = "Everything it's ok";
                }
                else
                {
                    retorno = "Houston tenemos un problema";
                }
                */
            }
            catch
            {
                showestaN= null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showestaN;


        }










































    }
}
