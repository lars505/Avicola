using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public bool Insertar(CE_Proveedor proveedor)
        {
            try
            {
                var ConexionDatos = new ConexionBD();
                SqlCommand Query = new SqlCommand();
                Query.CommandText = "INSERT INTO Proveedor (CodDepartamento, CodMunicipio, NombreProveedor, NombreContacto, Direccion, Telefono, Email)" +
                                    "VALUES(©Idproveedor,@CodDepartamento,@CodMunicipio,@nombreproveedor,@nombrecontacto,@direccion,@telefono,@email)";
                //Query.Parameters.AddWithValue("@IdProveedor", proveedor.Id);
                Query.Parameters.AddWithValue("@CodDepartamento", proveedor.CodDepartamento);
                Query.Parameters.AddWithValue("@CodMunicipio", proveedor.CodMunicipio);
                Query.Parameters.AddWithValue("@nombreproveedor", proveedor.Nombre);
                Query.Parameters.AddWithValue("@nombrecontacto", proveedor.Nombrecontacto);
                Query.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                Query.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                Query.Parameters.AddWithValue("@email", proveedor.Email);

                ConexionDatos.EjecutarConsultasql(Query);
            }
            catch (Exception e)
            {
                Console.Write(e.Message); }
            return true;
        }

                

         public bool Eliminar(CE_Proveedor proveedor)
        {
            try
            {
                var ConexionDatos = new ConexionBD();
                SqlCommand Query = new SqlCommand();
                Query.CommandText = "Delete Proveedor where IdProveedor = @IdProveedpr";
                Query.Parameters.AddWithValue("@IdProveedor", proveedor.Id);
                ConexionDatos.EjecutarConsultasql(Query);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Actualizar(CE_Proveedor Proveedor)
        {
            try
            {
                var ConexionDatos = new ConexionBD();
                SqlCommand Query = new SqlCommand();

                Query.CommandText = "UPDATE Proveedor SET" +
                                     "CodDepartamento = @CodDepartamento," +
                                     "CodMunicipio = @CodMunicipio," +
                                     "NombreProveedor = @nombreproveedor," +
                                     "NombreContacto = @nombrecontacto ," +
                                     "Direccion=@direccion," +
                                     "Telefono=@telefono," +
                                     "Email=@email" + 
                                     "WHERE IdProveedor = @IdProveedor";
                Query.Parameters.AddWithValue("@IdProveedor", Proveedor.Id);
                Query.Parameters.AddWithValue("@CodDepartamento", Proveedor.CodDepartamento);
                Query.Parameters.AddWithValue("@CodMunicipio", Proveedor.CodMunicipio);
                Query.Parameters.AddWithValue("@nombreproveedor", Proveedor.Nombre);
                Query.Parameters.AddWithValue("@nombrecontacto", Proveedor.Nombrecontacto);
                Query.Parameters.AddWithValue("@direccion", Proveedor.Direccion);
                Query.Parameters.AddWithValue("@telefono", Proveedor.Telefono);
                Query.Parameters.AddWithValue("@email", Proveedor.Email);

                ConexionDatos.EjecutarConsultasql(Query);
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }
            

        public DataTable Seleccionar()
        {
            var ConexionDatos = new ConexionBD();
            string Query = "SELECT * FROM Proveedor";
            return ConexionDatos.Tablasql(Query);
        }


        public DataTable SeleccionarPorNombre(string Nombre)
        {
            var ConexionDatos = new ConexionBD();
            String Query = "SELECT * FROM Proveedor WHERE Nombre LIKE '" + Nombre + "'+'%'";
            return ConexionDatos.Tablasql(Query);
        }


    }


 }

