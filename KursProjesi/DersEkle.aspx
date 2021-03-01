<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DersEkle.aspx.cs" Inherits="KursProjesi.DersEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
     <title>Öğrenciler</title>
  
        <script src="Boostrap/js/bootstrap.min.js"></script>
<link href="Boostrap/css/bootstrap.css" rel="stylesheet" />
    <link href="Boostrap/css/bootstrap.min.css" rel="stylesheet" />
     <script src="Boostrap/js/jquery-3.3.1.min.js"></script>
     <script src="Boostrap/js/popper.min.js"></script>
  
     
   
 </head>
    <body>
     <form id="Form1" runat="server">

      <div class=" form-group"">
          <br/>
          <div>
              <asp:Label  for="txtDersAd" runat="server" Text="Ders Ad:" style="font-weight: bold"></asp:Label>
          <asp:TextBox ID="txtDersAd" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br/>
          <div>
            <asp:Label for="txtDersUcret" runat="server" Text="Ders Ucret:" style="font-weight: 700"></asp:Label>
          <asp:TextBox ID="txtDersUcret" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
         
      <asp:Button ID="Button1" runat="server" Text="Ders Ekle" onClick="Button1_Click1" CssClass="btn btn-info" /> 
      </div>

      
</form>
    </body>
</asp:Content>
