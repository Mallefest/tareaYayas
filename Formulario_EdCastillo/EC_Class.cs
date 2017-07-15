using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Formulario_EdCastillo
{
    class EC_Class
    {
        // <summary> 
        /// Conexión a la Base de Datos con SQLOLEDB 
        /// </summary> 
        /// <returns>string de Conexión a la Base de Datos</returns> 


        public string GetConnectionString()
        {
            return Properties.Settings.Default.Formulario_EDCastillToroConnectionString1;

        }
        /// <summary> 
        /// Ejecuta un comando SQL 
        /// </summary> 
        /// <param name="sComandoSql">Comando SQL para ejecutar Insert, Delete y Update</param>
        public void EjecutaSQLComando(string sComandoSql)
        {
            SqlConnection sqlConn = new SqlConnection();
            SqlCommand sqlCom = new SqlCommand();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sqlCom.CommandText = sComandoSql;
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                /*if (error == null)
                {
                    throw error;
                }*/
                
                MessageBox.Show(error.Message);


            }
            finally
            {
                sqlConn.Close();
            }
        }
        /// <summary> 
        /// Ejecuta un comando SQL y retorna un parámetro 
        /// </summary> 
        /// <param name="sComandoSql">Comando SQL</param> 
        public string EjecutaSQLScalar(string sComandoSql)
        {
            string regreso = "";
            SqlConnection sqlConn = new SqlConnection();
            SqlCommand sqlCom = new SqlCommand();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sqlCom.CommandText = sComandoSql;
                regreso = sqlCom.ExecuteScalar().ToString();
            }
            catch (Exception error)
            {
                if (error == null)
                {

                    throw error;

                    //MessageBox.Show(error.Message.ToString()); 
                }

            }
            finally
            {
                sqlConn.Close();
            }
            Console.WriteLine(regreso);
            return regreso;
        }
        /// <summary> 
        /// Esta Función Sirve para llenar GridsView y Combos 
        /// Regresa un DataSet por lo que puede servir para mas 
        /// Controles de Datos 
        /// </summary> 
        /// <param name="mysql">mySql es la Sentencia en a Ejecutar para el llenado del Control</param> 
        /// <returns>Dataset para su llenado,DataGrids, Combos, etc</returns> 
        public DataSet LLenaComboGrid(string mysql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cnn.ConnectionString = GetConnectionString();
                cnn.Open();
                cmd.CommandText = mysql;
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cnn;
                da.Fill(ds);
            }
            catch (System.Data.SqlClient.SqlException error)
            {
                MessageBox.Show(error.ToString());

            }
            cnn.Close();
            return ds;
        }

    }
} 



    
