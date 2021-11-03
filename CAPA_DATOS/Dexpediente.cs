using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CAPA_DATOS
{
    public class Dexpediente
    {

        int ID_Expediente;
        string Nombre;
        string Estado;
        byte[] Foto;
        string Noexpediente;
        string estu;
        int ID_Remision;

        public Dexpediente() { }

        /*public Dexpediente(string iD_Expediente, string nombre, string estado, byte[] foto, string noexpediente)
        {
            ID_Expediente = iD_Expediente;
            Nombre = nombre;
            Estado = estado;
            Foto = foto;
            Noexpediente = noexpediente;
        }*/

        public Dexpediente( int id_Expediente,string nombre1, string estado1, byte[] foto1, string noexpediente1,string estu, int idremi)
        {
            ID_Expediente1 = id_Expediente;
            Nombre1 = nombre1;
            Estado1 = estado1;
            Foto1 = foto1;
            Noexpediente1 = noexpediente1;
            Estu = estu;
            ID_Remision1 = idremi;
        }


        public int ID_Expediente1 { get => ID_Expediente; set => ID_Expediente = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public byte[] Foto1 { get => Foto; set => Foto = value; }
        public string Noexpediente1 { get => Noexpediente; set => Noexpediente = value; }
        public string Estu { get => estu; set => estu = value; }
        public int ID_Remision1 { get => ID_Remision; set => ID_Remision = value; }

        public string insertexpediente(Dexpediente expE)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEX = new SqlCommand();
                SP_NewEX.Connection = Conectar;
                SP_NewEX.CommandText = "psci.SP_NewE";
                SP_NewEX.CommandType = CommandType.StoredProcedure;

                SqlParameter idre = new SqlParameter();
                idre.ParameterName = "@id_remi";
                idre.SqlDbType = SqlDbType.Int;
                idre.Value = expE.ID_Remision1;
                SP_NewEX.Parameters.Add(idre);

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@id_expe";
                id.SqlDbType = SqlDbType.Int;
                id.Value = expE.ID_Expediente1;
                SP_NewEX.Parameters.Add(id);

                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.SqlDbType = SqlDbType.NVarChar;
                Nombre.Size = 50;
                Nombre.Value = expE.Nombre1;
                SP_NewEX.Parameters.Add(Nombre);

                SqlParameter Estado = new SqlParameter();
                Estado.ParameterName = "@Estado";
                Estado.SqlDbType = SqlDbType.NChar;
                Estado.Value = expE.Estado1;
                SP_NewEX.Parameters.Add(Estado);

                SqlParameter Foto = new SqlParameter();
                Foto.ParameterName = "@Foto";
                Foto.SqlDbType = SqlDbType.Image;
                //Nombre.Size = 50;
                Foto.Value = expE.Foto1;
                SP_NewEX.Parameters.Add(Foto);

               


                SqlDataReader sqlDataReader3 = SP_NewEX.ExecuteReader();


                if(sqlDataReader3.HasRows)
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


        public string UpdateDexpediente(Dexpediente expE)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEX = new SqlCommand();
                SP_NewEX.Connection = Conectar;
                SP_NewEX.CommandText = "psci.SP_UpdateE";
                SP_NewEX.CommandType = CommandType.StoredProcedure;

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@id_expe";
                id.SqlDbType = SqlDbType.Int;
                id.Value = expE.ID_Expediente1;
                SP_NewEX.Parameters.Add(id);

                SqlParameter Foto = new SqlParameter();
                Foto.ParameterName = "@Foto";
                Foto.SqlDbType = SqlDbType.Image;
                //Nombre.Size = 50;
                Foto.Value = expE.Foto1;
                SP_NewEX.Parameters.Add(Foto);





                if (SP_NewEX.ExecuteNonQuery() == 1)
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

        public DataTable showEX()
        {

            DataTable showexpediente = new DataTable("expediente");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEX = new SqlCommand();
                SP_NewEX.Connection = Conectar;
                SP_NewEX.CommandText = "psci.SP_ShowE";
                SP_NewEX.CommandType = CommandType.StoredProcedure;




                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewEX);
                adartar.Fill(showexpediente);



                if (SP_NewEX.ExecuteNonQuery() == 1)
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
            return showexpediente;


        }


        public DataTable buscarexpediente(Dexpediente expe)
        {

            DataTable showexpediente = new DataTable("expediente");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEX = new SqlCommand();
                SP_NewEX.Connection = Conectar;
                SP_NewEX.CommandText = "psci.SP_BuscarE";
                SP_NewEX.CommandType = CommandType.StoredProcedure;

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.NChar;
                nombre.Value = expe.Nombre1;
                SP_NewEX.Parameters.Add(nombre);

               



                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewEX);
                adartar.Fill(showexpediente);



                if (SP_NewEX.ExecuteNonQuery() == 1)
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
            return showexpediente;


        }


        public DataTable ReporteExpediente(string Name)
        {

            DataTable showexpedienteb = new DataTable();
            //string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEXb = new SqlCommand();
                SP_NewEXb.Connection = Conectar;
                SP_NewEXb.CommandText = "[psci].[RptExp]";
                SP_NewEXb.CommandType = CommandType.StoredProcedure;

                SP_NewEXb.Parameters.AddWithValue("@Nombre", Name);
                /*SqlParameter nombre1 = new SqlParameter();
                nombre1.ParameterName = "@Nombre";
                nombre1.SqlDbType = SqlDbType.NChar;
                nombre1.Value = Name;
                SP_NewEXb.Parameters.Add(nombre1);*/

                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewEXb);
                adartar.Fill(showexpedienteb);
                
            }
            catch
            {
                showexpedienteb = null;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return showexpedienteb;


        }


        public string baja(Dexpediente esta)
        {
            string retorno = "";

            SqlConnection conectar = new SqlConnection();
            try
            {
                conectar.ConnectionString = Conet.cnx;
                conectar.Open();

                SqlCommand bajaex = new SqlCommand();
                bajaex.Connection = conectar;
                bajaex.CommandText = "psci.SP_bajaE";
                bajaex.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@Id_ex";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = esta.ID_Expediente1;
                bajaex.Parameters.Add(ID);

                SqlParameter Estado = new SqlParameter();
                Estado.ParameterName = "@Estado";
                Estado.SqlDbType = SqlDbType.NChar;
                Estado.Value = esta.Estado1;
                bajaex.Parameters.Add(Estado);

                if (bajaex.ExecuteNonQuery() == 1)
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
                if (conectar.State == ConnectionState.Open)
                {
                    conectar.Close();
                }
            }
            return retorno;
            
        } 

        public DataTable mostrarfoto(Dexpediente fo)
        {
            DataTable mostrarfoto = new DataTable();
            string retorno = "";
            SqlConnection conectar = new SqlConnection();
            try
            {
                conectar.ConnectionString = Conet.cnx;
                conectar.Open();

                SqlCommand expe = new SqlCommand();
                expe.Connection = conectar;
                expe.CommandText = "psci.SP_showF";
                expe.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@ID_Expediente";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = fo.ID_Expediente1;
                expe.Parameters.Add(ID);
                
                if (expe.ExecuteNonQuery() == 1)
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
                if(conectar.State== ConnectionState.Open)
                {
                    conectar.Close();
                }
            }
            return mostrarfoto;
        }

        public DataTable buscarestudiante( Dexpediente exped)
        {
            DataTable mostraestu = new DataTable();
            string retorno = "";
            SqlConnection conectar = new SqlConnection();
            try
            {
                conectar.ConnectionString = Conet.cnx;
                conectar.Open();

                SqlCommand expe = new SqlCommand();
                expe.Connection = conectar;
                expe.CommandText = "psci.SP_BuscarEs";
                expe.CommandType = CommandType.StoredProcedure;

                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.SqlDbType = SqlDbType.NChar;
                Nombre.Value = exped.Estu;
                expe.Parameters.Add(Nombre);

                SqlDataAdapter adartar = new SqlDataAdapter(expe);
                adartar.Fill(mostraestu);

                SqlDataReader reader = expe.ExecuteReader();


                if (reader.HasRows)
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
                if (conectar.State == ConnectionState.Open)
                {
                    conectar.Close();
                }
            }
            return mostraestu;
        }


        public DataTable buscarexpedientecita(Dexpediente expe)
        {

            DataTable showexpedientecita = new DataTable("expediente");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewEX = new SqlCommand();
                SP_NewEX.Connection = Conectar;
                SP_NewEX.CommandText = "psci.SP_combinacion2";
                SP_NewEX.CommandType = CommandType.StoredProcedure;

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.NChar;
                nombre.Value = expe.Nombre1;
                SP_NewEX.Parameters.Add(nombre);





                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewEX);
                adartar.Fill(showexpedientecita);



                if (SP_NewEX.ExecuteNonQuery() == 1)
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
            return showexpedientecita;


        }











    }

















}





