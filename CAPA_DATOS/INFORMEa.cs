using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class INFORMEa
    {

        DateTime fecha;
        DateTime fech2;
        int edad;
        string sexo;
        int grado;
        string motivo;

        public INFORMEa(DateTime fecha, DateTime fech2, int edad, string sexo, int grado)
        {
            Fecha = fecha;
            Fech2 = fech2;
            Edad = edad;
            Sexo = sexo;
            Grado = grado;
        }







        public INFORMEa()
        {

        }



        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Fech2 { get => fech2; set => fech2 = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Grado { get => grado; set => grado = value; }
        public string Motivo { get => motivo; set => motivo = value; }


        public DataTable Reportegrado(DateTime fecha, DateTime fecha2, int grado1)
        {

            DataTable showexpedienteG = new DataTable();
            //string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEXb = new SqlCommand();
                SP_NewEXb.Connection = Conectar;
                SP_NewEXb.CommandText = "[psci].[sp_atencionG]";
                SP_NewEXb.CommandType = CommandType.StoredProcedure;

                SP_NewEXb.Parameters.AddWithValue("@Fecha", fecha.Date);
                SP_NewEXb.Parameters.AddWithValue("@fecha2", fecha2.Date);
                SP_NewEXb.Parameters.AddWithValue("@grado", grado1);

                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewEXb);
                adartar.Fill(showexpedienteG);

            }
            catch (Exception R)
            {
                showexpedienteG = null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showexpedienteG;


        }

        public DataTable Reportesexo(DateTime fecha, DateTime fecha2, string sexo1)
        {

            DataTable showexpedienteS = new DataTable();
            //string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEXb = new SqlCommand();
                SP_NewEXb.Connection = Conectar;
                SP_NewEXb.CommandText = "[psci].[sp_atencionS]";
                SP_NewEXb.CommandType = CommandType.StoredProcedure;

                SP_NewEXb.Parameters.AddWithValue("@Fecha", fecha.Date);
                SP_NewEXb.Parameters.AddWithValue("@fecha2", fecha2.Date);
                SP_NewEXb.Parameters.AddWithValue("@sexo", sexo1);

                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewEXb);
                adartar.Fill(showexpedienteS);

            }
            catch
            {
                showexpedienteS = null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showexpedienteS;


        }


        public DataTable Reporteedad(DateTime fecha, DateTime fecha2, int Edad1)
        {

            DataTable showexpedienteE = new DataTable();
            //string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEXb = new SqlCommand();
                SP_NewEXb.Connection = Conectar;
                SP_NewEXb.CommandText = "[psci].[sp_atencionE]";
                SP_NewEXb.CommandType = CommandType.StoredProcedure;

                SP_NewEXb.Parameters.AddWithValue("@Fecha", fecha.Date);
                SP_NewEXb.Parameters.AddWithValue("@fecha2", fecha2.Date);
                SP_NewEXb.Parameters.AddWithValue("@edad", Edad1);

                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewEXb);
                adartar.Fill(showexpedienteE);

            }
            catch
            {
                showexpedienteE = null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showexpedienteE;


        }

        public DataTable ReporteMotivo(DateTime fecha, DateTime fecha2, string moti1)
        {

            DataTable showexpedienteM = new DataTable();
            //string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEXb = new SqlCommand();
                SP_NewEXb.Connection = Conectar;
                SP_NewEXb.CommandText = "[psci].[sp_atencionM]";
                SP_NewEXb.CommandType = CommandType.StoredProcedure;

                SP_NewEXb.Parameters.AddWithValue("@Fecha", fecha.Date);
                SP_NewEXb.Parameters.AddWithValue("@fecha2", fecha2.Date);
                SP_NewEXb.Parameters.AddWithValue("@moti", moti1);

                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewEXb);
                adartar.Fill(showexpedienteM);

            }
            catch
            {
                showexpedienteM = null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showexpedienteM;


        }


















    }
}
