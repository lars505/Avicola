using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class ConexionBD
    {
        public string cadena = "Data Source=LARSDESKTOP\\SQLEXPRESS;Initial Catalog=BDF;Integrated Security=True";
        
        //Metodo para ejecutar Consultas
        public void EjecutarConsultasql(SqlCommand Query)
        {
            SqlConnection Conexion = new SqlConnection(cadena);
            Conexion.Open();
            SqlCommand command = Query;
            command.Connection = Conexion;

            command.ExecuteNonQuery();
            Conexion.Close();
        }

        //Metodo para Ejecutar tablas
        public DataTable Tablasql(string Query)
        {
            SqlConnection Conexion = new SqlConnection(cadena);
            DataTable dt = new DataTable();
            Conexion.Open();

            var comand = new SqlCommand(Query, Conexion);
            SqlDataAdapter ds = new SqlDataAdapter(comand);
            ds.Fill(dt);
            Conexion.Close();
            return dt;

        }

        public DataTable Ejecutar(string query)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            DataTable dt = new DataTable();
            conexion.Open();

            var command = new SqlCommand(query, conexion);
            SqlDataAdapter ds = new SqlDataAdapter();
            ds.Fill(dt);
            command.ExecuteNonQuery();
            conexion.Close();
            return dt;


        }






    }
}
