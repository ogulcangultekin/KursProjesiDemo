<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="KursProjesi.Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
        <title>Ders Listesi</title>
        <script src="Boostrap/js/bootstrap.min.js"></script>
        <link href="Boostrap/css/bootstrap.css" rel="stylesheet" />
        <link href="Boostrap/css/bootstrap.min.css" rel="stylesheet" />
        <script src="Boostrap/js/jquery-3.3.1.min.js"></script>
        <script src="Boostrap/js/popper.min.js"></script>
    </head>
    <body>
        <form id="form1" runat="server">

              <div>
                <asp:Label ID="Label3" runat="server" Text="Ogrenci ID:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Ders Seçin:" Style="font-weight: 700"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
            </asp:DropDownList>
            <br />
          
            <br />
            <div>

                <asp:Button ID="Button1" runat="server" Text="Ders Talebi Oluştur" CssClass="btn btn-warning" OnClick="Button1_Click" />

            </div>

        </form>
    </body>
</asp:Content>

