<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Proveedor.aspx.cs" Inherits="Avicola.view.Proveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hola Baby costumer</h1>

    <!-- Vertically centered modal -->
    <!-- Button trigger modal -->
    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
      Nuevo
    </button>

    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
      <div class="modal-dialog modal-dialog-centered modal-dialog modal-xl">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Agregar Proveedores</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
              <h1>Aqui se agregara un nuevo proveedor</h1>
              <div class="form-group">
                    <p>CodDepartamento:<asp:TextBox runat="server" CssClass="TxtForm form-control" placeholder="CodDepartamento"  ID="CodDep"  /></p>
               </div>
              <div class="form-group">
                    <p>CodMunicipio:<asp:TextBox runat="server" CssClass="TxtForm form-control" placeholder="CodDepartamento"  ID="CodMun"  /></p>
               </div>
              <div class="form-group">
                    <p>Nombre Proveedor:<asp:TextBox runat="server" CssClass="TxtForm form-control" placeholder="Nombre"  ID="NombreProv"  /></p>
               </div>
              <div class="form-group">
                    <p>Nombre Contacto:<asp:TextBox runat="server" CssClass="TxtForm form-control" placeholder="Nombre"  ID="NombreContacto"  /></p>
               </div>
                <div>
                    <p>
                        <%--Categoria:<asp:DropDownList ID="DropDownList1" runat="server" CssClass="TxtForm" DataSourceID="SqlDataSource1" DataValueField="Nombre">
                        </asp:DropDownList>--%>
                        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NegocioConnectionString2 %>" SelectCommand="SELECT [Nombre] FROM [CatCategoria]"></asp:SqlDataSource>--%>
                    </p>
                </div>
                <div>
                    <p>
                       <%-- Marca:<asp:DropDownList ID="DropDownMarca" CssClass="TxtForm" runat="server" DataSourceID="SqlDataSource2" DataValueField="NombreMar">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NegocioConnectionString3 %>" SelectCommand="SELECT [NombreMar] FROM [Marca]"></asp:SqlDataSource>--%>
                    </p>
                </div>
                <div>
                    <p>Dereccio:<asp:TextBox runat="server" CssClass="TxtForm" placeholder="Direccion"  ID="Direccion" /></p>
                </div>
                <div>
                    <p>Telefono:<asp:TextBox runat="server" CssClass="TxtForm" placeholder="Telefono" ID="telefono" /></p>
                </div>
                <div>
                    <p>Email:<asp:TextBox runat="server" CssClass="TxtForm" placeholder="Email" ID="Email" /></p>
                </div>
                <div>
                   <%-- <asp:Button ID="Agregar" runat="server" Text="Crear" OnClick="Agregar_Click" />
                    <asp:Button ID="Cancelar" OnClick="Cancelar_Click" runat="server" Text="Cancelar" />--%>
                </div>
              <br />
          </div>
          <div class="modal-footer">
            <asp:button type="button" Cssclass="btn btn-danger" data-dismiss="modal" ID="Cancelar" runat="server" Text="Cancelar"/>
            <asp:button type="button" Cssclass="btn btn-primary" OnClick="Guardar_Click" ID="Guardar" runat="server"  Text ="Guardar"/>
          </div>
        </div>
      </div>
    </div>

</asp:Content>
