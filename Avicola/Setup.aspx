<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Setup.aspx.cs" Inherits="Avicola.Setup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
    Add new element
  </button>

<!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Registro de Clientes</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <asp:TextBox CssClass="form-control" ID="Nombre" placeholder="Nombre" runat="server"></asp:TextBox>
          <div class="mt-2"></div>
            <asp:TextBox CssClass="form-control" ID="ApellidoP" placeholder="ApellidoP" runat="server"></asp:TextBox>
            <div class="mt-2"></div>
      <asp:TextBox CssClass="form-control" ID="ApellidoM" Placeholder="ApellidoM" runat="server"></asp:TextBox>
           <div class="mt-2"></div>
          <asp:TextBox CssClass="form-control" ID="Telefono" Placeholder="Telefono" runat="server"></asp:TextBox>
           <div class="mt-2"></div>
          <asp:DropDownList CssClass="form-control" ID="DropDownListDepartamento" OnLoad="DropDownListDepartamento_Load" placeholder="Departamento" runat="server" DataValueField="idDepartamento" DataTextField="Nombre">
          </asp:DropDownList>
            
            <div class="mt-2"></div>
          <asp:DropDownList CssClass="form-control" ID="DropDownListMunicipio" OnLoad="DropDownListMunicipio_Load" placeholder="Municipio" runat="server" DataValueField="IdMunicipio" DataTextField="Nombre" ></asp:DropDownList>
            
            <div class="mt-2"></div>
          <asp:TextBox CssClass="form-control" ID="Direccion" Placeholder="Direccion" runat="server"></asp:TextBox>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <asp:Button runat="server" OnClick="Add_Click" Id="Add" CssClass="btn btn-primary" Text="Save changes" />
      </div>
    </div>
  </div>
    </div>

    <!-- Modal2-->
  

<!-- Modal -->
<div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel2">Modificacion de Clientes</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
          
        <asp:TextBox CssClass="form-control" ID="Nombre2"  Text='<% # Bind("Nombre") %>' placeholder="Nombre" runat="server"></asp:TextBox>
          <div class="mt-2"></div>
            <asp:TextBox CssClass="form-control" OnLoad="ApellidoP2_Load" ID="ApellidoP2" placeholder="ApellidoP" runat="server"></asp:TextBox>
            <div class="mt-2"></div>
      <asp:TextBox CssClass="form-control" ID="ApellidoM2" Placeholder="ApellidoM" runat="server"></asp:TextBox>
           <div class="mt-2"></div>
          <asp:TextBox CssClass="form-control" ID="Telefono2" Placeholder="Telefono" runat="server"></asp:TextBox>
           <div class="mt-2"></div>
          <asp:DropDownList CssClass="form-control" ID="DropDownListDepartamento2" OnLoad="DropDownListDepartamento_Load" placeholder="Departamento" runat="server" DataValueField="idDepartamento" DataTextField="Nombre">
          </asp:DropDownList>
            
            <div class="mt-2"></div>
          <asp:DropDownList CssClass="form-control" ID="DropDownListMunicipio2" OnLoad="DropDownListMunicipio_Load" placeholder="Municipio" runat="server" DataValueField="IdMunicipio" DataTextField="Nombre" ></asp:DropDownList>
            
            <div class="mt-2"></div>
          <asp:TextBox CssClass="form-control" ID="Direccion2" Placeholder="Direccion" runat="server"></asp:TextBox>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <asp:Button runat="server" Onclick="Update_Click" Id="Update" CssClass="btn btn-primary" Text="Save changes" />
      </div>
    </div>
  </div>
    </div>
     <div class="mt-2"></div>
  
    <!--GridView-->   
    <div>
        
    <asp:GridView  ID="GridCliente" Cssclass="table table-striped col-sm-6"  runat="server" OnSelectedIndexChanged="GridCliente_SelectedIndexChanged" Width="705px" AutoGenerateColumns="False">
        <Columns >
                  <asp:TemplateField  HeaderText="Identificador">
                <ItemTemplate>
                    <asp:Label ID="Label9" OnLoad="Label9_Load" runat="server" Text='<% # Bind("IdCliente") %>'></asp:Label>
                    
                </ItemTemplate>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<% # Bind("Nombre") %>'></asp:Label>
                </ItemTemplate>
               </asp:TemplateField>
             <asp:TemplateField HeaderText="Surname">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<% # Bind("ApellidoP") %>'></asp:Label>
                </ItemTemplate>
               </asp:TemplateField>
             <asp:TemplateField HeaderText="Surname">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<% # Bind("ApellidoM") %>'></asp:Label>
                </ItemTemplate>
               </asp:TemplateField>
             <asp:TemplateField HeaderText="Celphone_Number">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<% # Bind("Telefono") %>'></asp:Label>
                </ItemTemplate>
               </asp:TemplateField>
             <asp:TemplateField HeaderText="Department">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<% # Bind("CodDepartamento") %>'></asp:Label>
                </ItemTemplate>
               </asp:TemplateField>
             <asp:TemplateField HeaderText="City_hall">
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
                    <button type="button"  class="btn btn-primary" data-toggle="modal" data-target="#exampleModal2">Update_new_element</button>                     
                   
                </ItemTemplate>
               </asp:TemplateField>
        </Columns>
    </asp:GridView>

    </div>
     <div class="mt-2"></div>
</asp:Content>

