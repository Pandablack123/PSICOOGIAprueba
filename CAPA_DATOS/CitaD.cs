using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CitaD
    {
        int ID_Cita;
        int ID_Remision;
        int id_expediente;
        DateTime Fecha;
        DateTime Hora;
        DateTime hoy;

        public CitaD(){}

        public CitaD(int iD_Cita1, int iD_Remision1, DateTime fecha1,DateTime hora1,DateTime hoy, int idexpe)
        {
            ID_Cita1 = iD_Cita1;
            ID_Remision1 = iD_Remision1;
            Fecha1 = fecha1;
            Hora1 = hora1;
            Hoy = hoy;
            Id_expediente = idexpe;
        }

        public int ID_Cita1 { get => ID_Cita; set => ID_Cita = value; }
        public int ID_Remision1 { get => ID_Remision; set => ID_Remision = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public DateTime Hora1 { get => Hora; set => Hora = value; }
        public DateTime Hoy { get => hoy; set => hoy = value; }
        public int Id_expediente { get => id_expediente; set => id_expediente = value; }

        public string insertcita(CitaD expCt)
        {
           string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_Newcita = new SqlCommand();
                sp_Newcita.Connection = Conectar;
                sp_Newcita.CommandText = "psci.SP_NewCi";
                sp_Newcita.CommandType = CommandType.StoredProcedure;



                SqlParameter remision = new SqlParameter();
                remision.ParameterName = "@ID_Expediente";
                remision.SqlDbType = SqlDbType.Int;
                //Cita.Size = 0;
                remision.Value = expCt.Id_expediente;
                sp_Newcita.Parameters.Add(remision);


                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                fecha.Value = expCt.Fecha1;
                sp_Newcita.Parameters.Add(fecha);

                SqlParameter hora = new SqlParameter();
                hora.ParameterName = "@Hora";
                hora.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                hora.Value = expCt.Hora1;
                sp_Newcita.Parameters.Add(hora);




                if (sp_Newcita.ExecuteNonQuery()==1)
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

        public string Updatecita(CitaD expCt)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_Newcita = new SqlCommand();
                sp_Newcita.Connection = Conectar;
                sp_Newcita.CommandText = "psci.SP_UpdateCi";
                sp_Newcita.CommandType = CommandType.StoredProcedure;

                SqlParameter Cita = new SqlParameter();
                Cita.ParameterName = "@ID_Cita";
                Cita.SqlDbType = SqlDbType.Int;
                //Cita.Size = 0;
                Cita.Value = expCt.ID_Cita1;
                sp_Newcita.Parameters.Add(Cita);

                SqlParameter Id_expe = new SqlParameter();
                Id_expe.ParameterName = "@ID_Expediente";
                Id_expe.SqlDbType = SqlDbType.Int;
                //Id_remision.Size = 50;
                Id_expe.Value = expCt.Id_expediente;
                sp_Newcita.Parameters.Add(Id_expe);


                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                fecha.Value = expCt.Fecha1;
                sp_Newcita.Parameters.Add(fecha);


                SqlParameter hora = new SqlParameter();
                hora.ParameterName = "@Hora";
                hora.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                hora.Value = expCt.Hora1;
                sp_Newcita.Parameters.Add(hora);



                if (sp_Newcita.ExecuteNonQuery() == 0)
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


        public DataTable showct()
        {

            DataTable showcita = new DataTable("cita");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_Newcita = new SqlCommand();
                sp_Newcita.Connection = Conectar;
                sp_Newcita.CommandText = "psci.SP_ShowCi";
                sp_Newcita.CommandType = CommandType.StoredProcedure;




                SqlDataAdapter adartar = new SqlDataAdapter(sp_Newcita);
                adartar.Fill(showcita);



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
            return showcita;


        }


        public DataTable buscarcita(Dexpediente expCt)
        {

            DataTable buscarcita = new DataTable("cita");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_New = new SqlCommand();
                sp_New.Connection = Conectar;
                sp_New.CommandText = "psci.SP_combinacion2";
                sp_New.CommandType = CommandType.StoredProcedure;

                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.SqlDbType = SqlDbType.NVarChar;
                Nombre.Size = 50;
                Nombre.Value = expCt.Nombre1;
                sp_New.Parameters.Add(Nombre);

               



                SqlDataAdapter adartar = new SqlDataAdapter(sp_New);
                adartar.Fill(buscarcita);



                if (sp_New.ExecuteNonQuery() == 1)
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
            return buscarcita;


        }

        public DataTable filtro(CitaD cita)
        {

            DataTable showcita = new DataTable("cita");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_Newcita = new SqlCommand();
                sp_Newcita.Connection = Conectar;
                sp_Newcita.CommandText = "psci.Filtro_fecha";
                sp_Newcita.CommandType = CommandType.StoredProcedure;

                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                fecha.Value = cita.Hoy;
                sp_Newcita.Parameters.Add(fecha);




                SqlDataAdapter adartar = new SqlDataAdapter(sp_Newcita);
                adartar.Fill(showcita);



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
            return showcita;


        }

















    }
}
