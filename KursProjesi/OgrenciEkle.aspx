<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciEkle.aspx.cs" Inherits="KursProjesi.Ogrenciler" %>
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
              <asp:Label  for="txtAd" runat="server" Text="Ögrenci Ad:" style="font-weight: bold"></asp:Label>
          <asp:TextBox ID="txtAd" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br/>
          <div>
            <asp:Label for="txtSoyad" runat="server" Text="Öğrenci Soyad:" style="font-weight: 700"></asp:Label>
          <asp:TextBox ID="txtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
          <br/>
          <div>
                <asp:Label for="txtNumara" runat="server" Text="Öğrenci Numara:" style="font-weight: 700"></asp:Label>
          <asp:TextBox ID="txtNumara" runat="server" CssClass="form-control"></asp:TextBox>
          </div>

          <br/>
          <div>
                <asp:Label for="txtMail" runat="server" Text="Öğrenci Mail:" style="font-weight: 700"></asp:Label>
          <asp:TextBox ID="txtMail" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br/>
          <div>
                <asp:Label for="txtTelefon" runat="server" Text="Öğrenci Telefon:" style="font-weight: bold"></asp:Label>
          <asp:TextBox ID="txtTelefon" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br/>
          <div>
                <asp:Label for="txtSifre" runat="server" Text="Öğrenci Sifre" style="font-weight: 700"></asp:Label>
          <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br/>
      <asp:Button ID="Button1" runat="server" Text="Ogrenci Ekleme" onClick="Button1_Click1" CssClass="btn btn-info" /> 
      </div>

      
</form>
    </body>
</asp:Content>
