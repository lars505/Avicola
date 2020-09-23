using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;

namespace Avicola
{
    public partial class Setup : System.Web.UI.Page
    {

        public void Cargar()
        {
            var obj = new ClienteDA();
            GridView grid = new GridView();
            grid = GridCliente;
            GridCliente.DataSource = obj.Seleccionar();
            GridCliente.DataBind();
        }
        public void cargadep()
        {
            var dep = new ClienteDA();
            DropDownList dropDownList = new DropDownList();
            dropDownList = DropDownListDepartamento;
            DropDownListDepartamento.DataSource = dep.Lista();

            DropDownListDepartamento.DataBind();
           
        }
        public void Cargamun()
        {
            var dep = new ClienteDA();
            DropDownList dropDownList = new DropDownList();
            dropDownList =DropDownListMunicipio;
            DropDownListMunicipio.DataSource = dep.ListaMun();
           DropDownListMunicipio.DataBind();
        }

      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {

                Cargar();
            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDA c = new ClienteDA();

                c.Nombre = Nombre.Text;
                c.ApellidoP = ApellidoP.Text;
                c.ApellidoM = ApellidoM.Text;
                c.Telefono =Convert.ToInt32( Telefono.Text);
                c.CodDepartamento =Convert.ToInt32( DropDownListDepartamento.SelectedValue);
                c.CodMunicipio =Convert.ToInt32( DropDownListMunicipio.SelectedValue);
                c.Direccion = Direccion.Text;

                if (c.Insertar(c)==true)
                {
                    Cargar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void DropDownListDepartamento_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                cargadep();
            }
        }

        protected void GridCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        protected void DropDownListMunicipio_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Cargamun();
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDA Cli = new ClienteDA();
                Cli.IdCliente = Cli.IdCliente;
                Cli.Nombre = Nombre2.Text;

                if (Cli.Actualizar() == true)
                {
                    Cargar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        protected void ApellidoP2_Load(object sender, EventArgs e)
        {
            
          
        }

        protected void Label9_Load(object sender, EventArgs e)
        {
          
        }
    }
}