<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciKisiselGuncelle.aspx.cs" Inherits="KursProjesi.OgrenciKisiselGuncelle" %>
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
          <div>
              <asp:Label  for="txtID" runat="server" Text="Ögrenci ID:" style="font-weight: bold"></asp:Label>
          <asp:TextBox ID="txtID" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br/>
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
       
          <br/>
      <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn btn-success" OnClick="Button1_Click"  /> 
      </div>

      
</form>
    </body>
</asp:Content>
