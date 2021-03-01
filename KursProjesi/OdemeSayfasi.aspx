<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OdemeSayfasi.aspx.cs" Inherits="KursProjesi.OdemeSayfasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <head>
     <title>Ödeme Sayfasi</title>
  
        <script src="Boostrap/js/bootstrap.min.js"></script>
<link href="Boostrap/css/bootstrap.css" rel="stylesheet" />
    <link href="Boostrap/css/bootstrap.min.css" rel="stylesheet" />
     <script src="Boostrap/js/jquery-3.3.1.min.js"></script>
     <script src="Boostrap/js/popper.min.js"></script>
           <script src="Boostrap/js/jquery-3.3.1.min.js"></script>
           <script src="Boostrap/js/jquery.form.min.js"></script>
           
 </head>
    <body>
     <form id="Form1" runat="server">

      <div class=" form-group"">
          <div>
              <asp:Label  for="txtID" runat="server" Text="Ögrenci ID:" style="font-weight: bold"></asp:Label>
          <asp:TextBox ID="txtID" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br/>
           <div>
              <asp:Label  for="txtUcret" runat="server" Text="Kalan Ücret:" style="font-weight: bold"></asp:Label>
          <asp:TextBox ID="txtUcret" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br/>
          <div>

          <div>
              <asp:Label  for="txtOdenecek" runat="server" Text="Ödenecek Tutar:" style="font-weight: bold"></asp:Label>
          <asp:TextBox ID="txtOdenecek" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <br/>


           <div>
            <asp:Label  for="txtTarih" runat="server" Text="Ödeme Tarihi:" style="font-weight: bold"></asp:Label>
          <input type="text" ID="txtDate" value="23/01/2021" style="width: 100px;" readonly="readonly" name="Date"  class="hasDatepicker"/>
          </div>
          <br/>
          <div>
         
      <asp:Button ID="Button1" runat="server" Text="Ödeme İşlemini Gerçekleştir"  CssClass="btn btn-success" OnClick="Button1_Click" /> 
      </div>

      
</form>
    </body>
</asp:Content>
