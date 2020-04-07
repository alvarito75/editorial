<%@ Page Language="C#" MasterPageFile="Editorial.master" CodeBehind="registrarusuario.aspx.cs" Inherits="WebApplication.registrarusuario" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container">
      <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">      
                        <center>
                           <img width="100px" src="images/imgs/generaluser.png"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Registrar Usuario</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Nombre</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Nombre"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Apellido</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Apellido"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Fecha de Nacimiento</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Fecha de Nacimiento" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Edad</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Edad" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Telefono</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Telefono" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Correo Electronico</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Correo Electronico" TextMode="Email"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Departamento</label>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Beni" Value="Beni" />
                              <asp:ListItem Text="Cochabamba" Value="Cochabamba" />
                              <asp:ListItem Text="La Paz" Value="La Paz" />
                              <asp:ListItem Text="Oruro" Value="Oruro" />
                              <asp:ListItem Text="Pando" Value="Pando" />
                              <asp:ListItem Text="Potosi" Value="Potosi" />
                              <asp:ListItem Text="Sucre" Value="Sucre" />
                              <asp:ListItem Text="Santa Cruz" Value="Santa Cruz" />
                              <asp:ListItem Text="Tarija" Value="Tarija" />
                           </asp:DropDownList>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <label>Direccion</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Direccion" TextMode="MultiLine" Rows="2"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <span class="badge badge-pill badge-info">Credenciales</span>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>ID de usuario</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox8" runat="server" placeholder="ID de usuario"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox9" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" />
                        </div>
                     </div>
                  </div>
               </div>
            </div>
            <a href="/"><< Volver al inicio</a><br><br>
         </div>
      </div>
   </div>
</asp:Content>