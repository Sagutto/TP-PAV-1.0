using System;
using System.Data.SqlClient;
using System.Data;

namespace TP_PAV_1._0.Datos
{
    public class DBConector
    {
        private string string_conexion;
        private static DBConector instance = new DBConector();

        private DBConector()
        {
            string_conexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\agust\\Desktop\\PAVProy\\TP PAV 1.0\\DataBase\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        }
        public static DBConector GetDBConector()
        {
            if (instance == null)
                instance = new DBConector();
            return instance;
        }

        public bool TestConection()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                // Establece que conexión usar
                conexion.ConnectionString = string_conexion;
                // Abre la conexión
                conexion.Open();
                cmd.Connection = conexion;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable ConsultarTablaSQL(string strSql)
        {
            SqlConnection Conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                Conexion.ConnectionString = string_conexion;
                Conexion.Open();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                CerrarConeccion(Conexion);
            }
        }

        public void EjecutarComando(string strSql)
        {
            SqlConnection Conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                Conexion.ConnectionString = string_conexion;
                Conexion.Open();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                CerrarConeccion(Conexion);
            }
        }

        private void CerrarConeccion(SqlConnection Conexion)
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
                Conexion.Dispose();
            }
        }
    }
}
