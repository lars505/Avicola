using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaNegocio;
using CapaDatos;

namespace Avicola.view
{
    public partial class Proveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Proveedor Proveedor = new CE_Proveedor();
                CD_Proveedor CDProveedor = new CD_Proveedor();
                Proveedor.CodDepartamento = Convert.ToInt32(CodDep.Text);
                Proveedor.CodMunicipio = Convert.ToInt32(CodMun.Text);
                Proveedor.Nombre = NombreProv.Text;
                Proveedor.Nombrecontacto = NombreContacto.Text;
                Proveedor.Direccion = Direccion.Text;
                Proveedor.Telefono = Convert.ToInt32(telefono.Text);
                Proveedor.Email = Email.Text;
                if (CDProveedor.Insertar(Proveedor)== true)
                {
                    Console.Write("Producto agregado");
                }
                else
                {
                    Console.WriteLine("Error al insertar producto");
                }

            }
            catch (Exception ex)
            {


                Console.WriteLine("Se ha Generado un error: " + ex.Message);
            }

        }
    }
}