<%@ Page Language="C#" MasterPageFile="Editorial.master" Inherits="WebApplication.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .gatoleye{
           
       border-radius: 20px;
        }
     
       section{
           font-family: 'po';
       }
       @font-face {
    font-family: 'po';
    src: url(/fonts/ChampagneLimousines.ttf);
}
       @font-face {
    font-family: 'io';
    src: url(/fonts/BebasKai.ttf);
}
       .ban1{
           margin: 10px auto;
    display: block;
               max-width: 100%;
       }

    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <section>
      <img class="ban1" src="/images/cochasoft/EDITORIAL COCHASOFT.png" class="img-fluid"/>
   </section>
   <section>
      <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Nuestros Productos</h2>
               </center>
            </div>
         </div>
         <div class="row">
            <div class="col-md-4">
               <center>
                  <img class="gatoleye" width="300px" src="/images/cochasoft/invetari.jpg"/>
                  <h4>Inventario Digital de libros</h4>
                  <p class="text-justify">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor. reprehenderit</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img class="gatoleye" width="300px" src="/images/cochasoft/gato de foto.jpg"/>
                  <h4>Busque su libro</h4>
                  <p class="text-justify">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor. reprehenderit</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img class="gatoleye" width="300px" src="/images/cochasoft/publicite.jpg"/>
                  <h4>Publicite su libro</h4>
                  <p class="text-justify">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor. reprehenderit</p>
               </center>
            </div>
         </div>
      </div>
   </section>
   <section>
      <img src="/images/cochasoft/banner1.jpg" class="ban1 img-fluid"/>
   </section>
   <section>
      <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Nuestro Proceso</h2>
                  <p><b>Seguimos el mejor proceso</b></p>
               </center>
            </div>
         </div>
         <div class="row">
            <div class="col-md-4">
               <center>
                  <img class="gatoleye" width="300px" src="/images/cochasoft/login.png" />
                  <h4>Logeate</h4>
                  <p class="text-justify">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor. reprehenderit</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img class="gatoleye" width="300px" src="/images/cochasoft/gatoleyendo.jpg"/>
                  <h4>Lee tu libro</h4>
                  <p class="text-justify">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor. reprehenderit</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img class="gatoleye" width="300px" src="/images/cochasoft/visitanos.jpg"/>
                  <h4>Visitanos</h4>
                  <p class="text-justify">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor. reprehenderit</p>
               </center>
            </div>
         </div>
      </div>
   </section>
</asp:Content>