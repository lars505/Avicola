<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Proveedor.aspx.cs" Inherits="Avicola.view.Proveedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <!-- Vertically centered modal -->
    <!-- Button trigger modal -->
    <button type="button" class=" btn btn-primary" data-toggle="modal" data-target="#exampleModal">
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
                        <p>CodDepartamento:<asp:TextBox runat="server" CssClass="TxtForm form-control" placeholder="CodDepartamento" ID="CodDep" /></p>
                    </div>
                    <div class="form-group">
                        <p>CodMunicipio:<asp:TextBox runat="server" CssClass="TxtForm form-control" placeholder="CodDepartamento" ID="CodMun" /></p>
                    </div>
                    <div class="form-group">
                        <p>Nombre Proveedor:<asp:TextBox runat="server" CssClass="TxtForm form-control" placeholder="Nombre" ID="NombreProv" /></p>
                    </div>
                    <div class="form-group">
                        <p>Nombre Contacto:<asp:TextBox runat="server" CssClass="TxtForm form-control" placeholder="Nombre" ID="NombreContacto" /></p>
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
                        <p>Dereccio:<asp:TextBox runat="server" CssClass="TxtForm" placeholder="Direccion" ID="Direccion" /></p>
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
                    <asp:Button type="button" CssClass="btn btn-danger" data-dismiss="modal" ID="Cancelar" runat="server" Text="Cancelar" />
                    <asp:Button type="button" CssClass="btn btn-primary" OnClick="Guardar_Click" ID="Guardar" runat="server" Text="Guardar" />
                </div>
            </div>
        </div>
    </div>

    <div class="container-fluid">

        <!-- Page Heading -->
        <h1 class="h3 mb-2 text-gray-800">Tables</h1>
        <div class="card shadow mb-4">
            <div class="card-header py-3">
                <h6 class="m-0 font-weight-bold text-primary">DataTables Example</h6>
            </div>
            <div class="card-body">
                <div class="table-responsive">

                    <asp:GridView ID="GridCliente" CssClass="table table-bordered" runat="server" Width="705px" AutoGenerateColumns="False">
                        <Columns>
                            <asp:TemplateField HeaderText="Identificador">
                                <ItemTemplate>
                                    <asp:Label ID="IdProveedor" runat="server" Text='<% # Bind("IdProveedor") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Proveedor">
                                <ItemTemplate>
                                    <asp:Label ID="NombreProveedor" runat="server" Text='<% # Bind("NombreProveedor") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nombre Contacto">
                                <ItemTemplate>
                                    <asp:Label ID="Nombrecontacto" runat="server" Text='<% # Bind("Nombrecontacto") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Direccion">
                                <ItemTemplate>
                                    <asp:Label ID="Direccion" runat="server" Text='<% # Bind("Direccion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Telefono">
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<% # Bind("Email") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Cod Department">
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<% # Bind("CodDepartamento") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Cod Municipio">
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<% # Bind("CodMunicipio") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Place_of_recidence">
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server" Text='<% # Bind("Direccion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Options">
                                <ItemTemplate>
                                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal2">Update_new_element</button>

                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
