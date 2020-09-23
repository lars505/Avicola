using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaEntidades
{
   public class ClienteDA
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public int Telefono { get; set; }
        public int CodDepartamento { get; set; }
        public int CodMunicipio { get; set; }
        public string Direccion { get; set; }

       public DataTable Seleccionar()
        {
            var conexionDatos = new ConexionBD();
            string Query = "select * from Cliente";
            return conexionDatos.tablasql(Query);
        }

        public DataTable  Lista()
        {
            var conexionDatos = new ConexionBD();
            string Query = "select idDepartamento, Nombre from Departamento";
            return conexionDatos.tablasql(Query);
        }

        public DataTable ListaMun()
        {
            var conexionDatos = new ConexionBD();
            string Query = "select IdMunicipio, Nombre from Municipio";
            return conexionDatos.tablasql(Query);
        }
        public DataTable extraer ()
        {
            var conexionDatos = new ConexionBD();
            string Query = "select * from Cliente";
            return conexionDatos.tablasql(Query);
        }
        public bool Insertar(ClienteDA cli)
        {
            try
            {
                var conexiondatos = new ConexionBD();
                SqlCommand Query = new SqlCommand();
                Query.CommandText = "INSERT INTO Cliente (Nombre,ApellidoP,ApellidoM,Telefono,CodDepartamento,CodMunicipio,Direccion)" +
                                  "Values (@Nombre,@ApellidoP,@ApellidoM,@Telefono,@CodDepartamento,@CodMunicipio,@Direccion)";
                Query.Parameters.AddWithValue("@Nombre", cli.Nombre);
                Query.Parameters.AddWithValue("@ApellidoP", cli.ApellidoP);
                Query.Parameters.AddWithValue("@ApellidoM", cli.ApellidoM);
                Query.Parameters.AddWithValue("@Telefono", cli.Telefono);
                Query.Parameters.AddWithValue("@CodDepartamento", cli.CodDepartamento);
                Query.Parameters.AddWithValue("@CodMunicipio",cli.CodMunicipio);
                Query.Parameters.AddWithValue("@Direccion", cli.Direccion);

                conexiondatos.Ejecutarconsultasql(Query);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
   
         public bool Actualizar()
        {
            try
            {
                var conexionDatos = new ConexionBD();
                SqlCommand Query = new SqlCommand();
                Query.CommandText = "Update Cliente " + "set " + "Nombre=@Nombre," + "ApellidoP=@ApellidoP, " + "ApellidoM=@ApellidoM, " +
                                   "Telefono=@Telefono," + "CodDepartamento=@CodDepartamento," + "CodMunicipio=@CodMunicipio," +
                                   "Direccion=@Direccion " + "where IdCliente=@IdCliente ";
                Query.Parameters.AddWithValue("@IdCliente", IdCliente);
                Query.Parameters.AddWithValue("@Nombre", Nombre);
                Query.Parameters.AddWithValue("@ApellidoP", ApellidoP);
                Query.Parameters.AddWithValue("@ApellidoM", ApellidoM);
                Query.Parameters.AddWithValue("@Telefono", Telefono);
                Query.Parameters.AddWithValue("@CodDepartamento", CodDepartamento);
                Query.Parameters.AddWithValue("@CodMunicipio", CodMunicipio);
                Query.Parameters.AddWithValue("@Direccion", Direccion);

                conexionDatos.Ejecutarconsultasql(Query);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
