using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data.SqlClient;
using System.Configuration;


namespace CapaNegocio
{
    public class CN_Proveedor
    {
        //CD_Proveedor A = new CD_Proveedor();
        //public DataTable Seleccionar()
        //{
        //    return A.seleccionar();
        //}

        CD_Proveedor ObjDato = new CD_Proveedor();

        //SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString)
        
         public List<CE_Proveedor>ListadoProveedor(string buscar)
        {
            return ObjDato.ListaProveedor(buscar);

        }
        
        public void InsertandoProveedor(CE_Proveedor Proveedor)
        {
            ObjDato.InsertarProveedor(Proveedor);
        }
        
        public void EditandoProveedor(CE_Proveedor Proveedor)
        {
            ObjDato.EditarProveedor(Proveedor);
        }

        public void EliminandoProveedor(CE_Proveedor Proveedor)
        {
            ObjDato.EliminarProveedor(Proveedor);
        }
    
    
    }
}
