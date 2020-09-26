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
        public void CargarGrid()
        {
            var obj = new CN_Proveedor();
            GridView grid = new GridView();
            grid = GridCliente;
            GridCliente.DataSource = obj.Grid();
            GridCliente.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarGrid();
            }
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Proveedor Proveedor = new CE_Proveedor();
                CN_Proveedor CNProveedor = new CN_Proveedor();
                Proveedor.CodDepartamento = Convert.ToInt32(CodDep.Text);
                Proveedor.CodMunicipio = Convert.ToInt32(CodMun.Text);
                Proveedor.NombreProveedor = NombreProv.Text;
                Proveedor.Nombrecontacto = NombreContacto.Text;
                Proveedor.Direccion = Direccion.Text;
                Proveedor.Telefono = Convert.ToInt32(telefono.Text);
                Proveedor.Email = Email.Text;
                CNProveedor.InsertandoProveedor(Proveedor);
                

            }
            catch (Exception ex)
            {


                Console.WriteLine("Se ha Generado un error: " + ex.Message);
            }

        }
    }
}