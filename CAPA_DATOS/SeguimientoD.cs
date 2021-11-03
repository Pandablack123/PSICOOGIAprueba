using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class SeguimientoD
    {
        int ID_Seguimiento;
        int ID_Expediente;
        DateTime Fecha_inicio;
        DateTime Fecha_final;
        string Observaciones;

        public SeguimientoD() { }

        public SeguimientoD(int iD_Seguimiento1, int id_expediente, DateTime fecha_inicio1, DateTime fecha_final1, string observaciones1)
        {
            ID_Seguimiento1 = iD_Seguimiento1;
            ID_Expediente1 = id_expediente;
            Fecha_inicio1 = fecha_inicio1;
            Fecha_final1 = fecha_final1;
            Observaciones1 = observaciones1;
        }

        public int ID_Seguimiento1 { get => ID_Seguimiento; set => ID_Seguimiento = value; }
       
        public DateTime Fecha_inicio1 { get => Fecha_inicio; set => Fecha_inicio = value; }
        public DateTime Fecha_final1 { get => Fecha_final; set => Fecha_final = value; }
        public string Observaciones1 { get => Observaciones; set => Observaciones = value; }
        public int ID_Expediente1 { get => ID_Expediente; set => ID_Expediente = value; }

        public string insertseguimiento(SeguimientoD expS)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewSe = new SqlCommand();
                SP_NewSe.Connection = Conectar;
                SP_NewSe.CommandText = "psci.SP_NewS";
                SP_NewSe.CommandType = CommandType.StoredProcedure;

                SqlParameter Id_expe = new SqlParameter();
                Id_expe.ParameterName = "@ID_Expediente";
                Id_expe.SqlDbType = SqlDbType.Int;
                //Id_seguimiento.Size = 50;
                Id_expe.Value = expS.ID_Expediente1;
                SP_NewSe.Parameters.Add(Id_expe);

                SqlParameter fecha_inicio = new SqlParameter();
                fecha_inicio.ParameterName = "@Fecha_inicio";
                fecha_inicio.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                fecha_inicio.Value = expS.Fecha_inicio1;
                SP_NewSe.Parameters.Add(fecha_inicio);

                SqlParameter fecha_final = new SqlParameter();
                fecha_final.ParameterName = "@Fecha_final";
                fecha_final.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                fecha_final.Value = expS.Fecha_final1;
                SP_NewSe.Parameters.Add(fecha_final);

                SqlParameter Observacion = new SqlParameter();
                Observacion.ParameterName = "@Observaciones";
                Observacion.SqlDbType = SqlDbType.NVarChar;
                Observacion.Size = 3000;
                Observacion.Value = expS.Observaciones1;
                SP_NewSe.Parameters.Add(Observacion);


                SqlDataReader dataReader = SP_NewSe.ExecuteReader();


                if (dataReader.HasRows)
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

        public string UpdateseguimientoO(SeguimientoD expS)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewSe = new SqlCommand();
                SP_NewSe.Connection = Conectar;
                SP_NewSe.CommandText = "psci.SP_UpdateObsS";
                SP_NewSe.CommandType = CommandType.StoredProcedure;

                SqlParameter Id_seguimiento = new SqlParameter();
                Id_seguimiento.ParameterName = "@ID_Seguimiento";
                Id_seguimiento.SqlDbType = SqlDbType.Int;
                //Id_seguimiento.Size = 50;
                Id_seguimiento.Value = expS.ID_Seguimiento1;
                SP_NewSe.Parameters.Add(Id_seguimiento);

                SqlParameter Observacion = new SqlParameter();
                Observacion.ParameterName = "@Observaciones";
                Observacion.SqlDbType = SqlDbType.NVarChar;
                Observacion.Size = 3000;
                Observacion.Value = expS.Observaciones1;
                SP_NewSe.Parameters.Add(Observacion);




                if (SP_NewSe.ExecuteNonQuery() == 1)
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

        public string UpdateseguimientoF(SeguimientoD expS)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewSe = new SqlCommand();
                SP_NewSe.Connection = Conectar;
                SP_NewSe.CommandText = "SP_UpdateFechS";
                SP_NewSe.CommandType = CommandType.StoredProcedure;

                SqlParameter Id_seguimiento = new SqlParameter();
                Id_seguimiento.ParameterName = "@ID_Seguimiento";
                Id_seguimiento.SqlDbType = SqlDbType.Int;
                //Id_seguimiento.Size = 50;
                Id_seguimiento.Value = expS.ID_Seguimiento1;
                SP_NewSe.Parameters.Add(Id_seguimiento);

                SqlParameter fecha_final = new SqlParameter();
                fecha_final.ParameterName = "@Fecha_final";
                fecha_final.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                fecha_final.Value = expS.Fecha_final1;
                SP_NewSe.Parameters.Add(fecha_final);




                if (SP_NewSe.ExecuteNonQuery() == 1)
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


        public DataTable showS()
        {

            DataTable showseguimeinto = new DataTable("seguimiento");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewSe = new SqlCommand();
                SP_NewSe.Connection = Conectar;
                SP_NewSe.CommandText = "psci.SP_ShowS";
                SP_NewSe.CommandType = CommandType.StoredProcedure;




                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewSe);
                adartar.Fill(showseguimeinto);



                if (SP_NewSe.ExecuteNonQuery() == 1)
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
            return showseguimeinto;


        }

      /*  public DataTable buscarseguimiento(SeguimientoD expS)
        {

            DataTable showseguimiento = new DataTable("seguimiento");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewSe = new SqlCommand();
                SP_NewSe.Connection = Conectar;
                SP_NewSe.CommandText = "SP_BuscarCT";
                SP_NewSe.CommandType = CommandType.StoredProcedure;

                




                SqlDataAdapter adartar = new SqlDataAdapter(sp_Newcita);
                adartar.Fill(showseguimiento);



                if (sp_Newcita.ExecuteNonQuery() == 1)
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
            return showseguimiento;


        }*/














    }
}    
 