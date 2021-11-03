using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class ConsultaD
    {
        string ID_Consulta;
        int ID_Cita;
        string Nombre;
        string Actividades;
        string Observaciones;
        string Tipo;
        

        public ConsultaD() { }

        public ConsultaD(string Nombre, string iD_Consulta1, int iD_Cita1, string actividades1, string observaciones1, string tipo1)
        {
            ID_Consulta1 = iD_Consulta1;
            ID_Cita = iD_Cita1;
            Actividades1 = actividades1;
            Observaciones1 = observaciones1;
            Tipo1 = tipo1;
            Nombre1 = Nombre;
        }

        public string ID_Consulta1 { get => ID_Consulta; set => ID_Consulta = value; }
        public int ID_Cita1 { get => ID_Cita; set => ID_Cita = value; }
        public string Actividades1 { get => Actividades; set => Actividades = value; }
        public string Observaciones1 { get => Observaciones; set => Observaciones = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }

        public string insertconsulta(ConsultaD expC)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_New_C = new SqlCommand();
                sp_New_C.Connection = Conectar;
                sp_New_C.CommandText = "psci.New_C";
                sp_New_C.CommandType = CommandType.StoredProcedure;


                SqlParameter Cita = new SqlParameter();
                Cita.ParameterName = "@ID_Cita";
                Cita.SqlDbType = SqlDbType.Int;
                //Cita.Size = 0;
                Cita.Value = expC.ID_Cita1;
                sp_New_C.Parameters.Add(Cita);

                SqlParameter Actividades = new SqlParameter();
                Actividades.ParameterName = "@Actividades";
                Actividades.SqlDbType = SqlDbType.NVarChar;
                Actividades.Size = 50;
                Actividades.Value = expC.Actividades1;
                sp_New_C.Parameters.Add(Actividades);

                SqlParameter Observacion = new SqlParameter();
                Observacion.ParameterName = "@Observaciones";
                Observacion.SqlDbType = SqlDbType.NVarChar;
                Observacion.Size = 3000;
                Observacion.Value = expC.Observaciones1;
                sp_New_C.Parameters.Add(Observacion);

                SqlParameter Tipo = new SqlParameter();
                Tipo.ParameterName = "@Tipo";
                Tipo.SqlDbType = SqlDbType.NChar;
                Tipo.Size = 10;
                Tipo.Value = expC.Tipo1;
                sp_New_C.Parameters.Add(Tipo);


                SqlDataReader sqlDataReader2 = sp_New_C.ExecuteReader();

                if (sqlDataReader2.HasRows)
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
            return retorno;


        }


        public string Updateconsulta(ConsultaD expC)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_New_C = new SqlCommand();
                sp_New_C.Connection = Conectar;
                sp_New_C.CommandText = "SP_UpdateC";
                sp_New_C.CommandType = CommandType.StoredProcedure;

                SqlParameter Consulta = new SqlParameter();
                Consulta.ParameterName = "@ID_Consulta";
                Consulta.SqlDbType = SqlDbType.Int;
                // Consulta.Size = 0;
                Consulta.Value = expC.ID_Consulta1;
                sp_New_C.Parameters.Add(Consulta);

                /* SqlParameter Cita = new SqlParameter();
                 Cita.ParameterName = "@ID_Cita";
                 Cita.SqlDbType = SqlDbType.Int;
                 //Cita.Size = 0;
                 Cita.Value = expC.ID_Cita1;
                 sp_New_C.Parameters.Add(Cita);*/

                SqlParameter Actividades = new SqlParameter();
                Actividades.ParameterName = "@Actividades";
                Actividades.SqlDbType = SqlDbType.NVarChar;
                Actividades.Size = 50;
                Actividades.Value = expC.Actividades1;
                sp_New_C.Parameters.Add(Actividades);

                SqlParameter Observacion = new SqlParameter();
                Observacion.ParameterName = "@Observaciones";
                Observacion.SqlDbType = SqlDbType.NVarChar;
                Observacion.Size = 3000;
                Observacion.Value = expC.Observaciones1;
                sp_New_C.Parameters.Add(Observacion);

                SqlParameter Tipo = new SqlParameter();
                Tipo.ParameterName = "@Tipo";
                Tipo.SqlDbType = SqlDbType.NChar;
                Tipo.Size = 1;
                Tipo.Value = expC.Tipo1;
                sp_New_C.Parameters.Add(Tipo);




                if (sp_New_C.ExecuteNonQuery() == 1)
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
            return retorno;

        }

        public DataTable showc()
        {

            DataTable showconsulta = new DataTable("consulta");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_New_C = new SqlCommand();
                sp_New_C.Connection = Conectar;
                sp_New_C.CommandText = "SP_ShowC";
                sp_New_C.CommandType = CommandType.StoredProcedure;




                SqlDataAdapter adartar = new SqlDataAdapter(sp_New_C);
                adartar.Fill(showconsulta);



                if (sp_New_C.ExecuteNonQuery() == 1)
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
              return showconsulta;


        }

        public DataTable buscarconsulta(ConsultaD expC)
        {

            DataTable showconsulta = new DataTable("consulta");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_New_C = new SqlCommand();
                sp_New_C.Connection = Conectar;
                sp_New_C.CommandText = "psci.SP_BuscarC";
                sp_New_C.CommandType = CommandType.StoredProcedure;

                SqlParameter Consulta = new SqlParameter();
                Consulta.ParameterName = "@Nombre";
                Consulta.SqlDbType = SqlDbType.NVarChar;
                // Consulta.Size = 0;
                Consulta.Value = expC.Nombre1;
                sp_New_C.Parameters.Add(Consulta);




                SqlDataAdapter adartar = new SqlDataAdapter(sp_New_C);
                adartar.Fill(showconsulta);



                if (sp_New_C.ExecuteNonQuery() == 1)
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
            return showconsulta;


        }

        public DataTable buscarconsultaA(ConsultaD expC)
        {

            DataTable showconsulta = new DataTable("consulta");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_New_C = new SqlCommand();
                sp_New_C.Connection = Conectar;
                sp_New_C.CommandText = "SP_BuscarA";
                sp_New_C.CommandType = CommandType.StoredProcedure;

                SqlParameter Cita = new SqlParameter();
                Cita.ParameterName = "@ID_Cita";
                Cita.SqlDbType = SqlDbType.Int;
                //Cita.Size = 0;
                Cita.Value = expC.ID_Cita1;
                sp_New_C.Parameters.Add(Cita);




                SqlDataAdapter adartar = new SqlDataAdapter(sp_New_C);
                adartar.Fill(showconsulta);



                if (sp_New_C.ExecuteNonQuery() == 1)
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
            return showconsulta;


        }

        public DataTable buscarconsultaO(ConsultaD expC)
        {

            DataTable showconsulta = new DataTable("consulta");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_New_C = new SqlCommand();
                sp_New_C.Connection = Conectar;
                sp_New_C.CommandText = "SP_BuscarO";
                sp_New_C.CommandType = CommandType.StoredProcedure;

                SqlParameter Consulta = new SqlParameter();
                Consulta.ParameterName = "@ID_Consulta";
                Consulta.SqlDbType = SqlDbType.Int;
                // Consulta.Size = 0;
                Consulta.Value = expC.ID_Consulta1;
                sp_New_C.Parameters.Add(Consulta);




                SqlDataAdapter adartar = new SqlDataAdapter(sp_New_C);
                adartar.Fill(showconsulta);



                if (sp_New_C.ExecuteNonQuery() == 1)
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
            return showconsulta;


        }

    }


}
