using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class ConexionBD
    {
        public string cadena = "data source=MARCOSGUEVARA\\SQLEXPRESS; initial catalog= Avicola; " +
                                  "user id=sa; password=123456; persist security info=true; packet size=4096";


        public void Ejecutarconsultasql(SqlCommand Query)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            SqlCommand command = Query;
            command.Connection = conexion;

            command.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable tablasql(string Query)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            DataTable dt = new DataTable();
            conexion.Open();

            var comand = new SqlCommand(Query, conexion);
            SqlDataAdapter ds = new SqlDataAdapter(comand);
            ds.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable Ejcutar(string query)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            DataTable dt = new DataTable();
            conexion.Open();
            var comand = new SqlCommand(query,conexion);
            SqlDataAdapter ds = new SqlDataAdapter();
            ds.Fill(dt);
            comand.ExecuteNonQuery();
            conexion.Close();
            return dt;
        }
    }
}
