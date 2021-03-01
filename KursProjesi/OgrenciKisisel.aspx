<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciKisisel.aspx.cs" Inherits="KursProjesi.OgrenciKisisel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <head>
        <title>Öğrenci Listeleme</title>
        <script src="Boostrap/js/bootstrap.min.js"></script>
        <link href="Boostrap/css/bootstrap.css" rel="stylesheet" />
        <link href="Boostrap/css/bootstrap.min.css" rel="stylesheet" />
        <script src="Boostrap/js/jquery-3.3.1.min.js"></script>
        <script src="Boostrap/js/popper.min.js"></script>
    </head>
    <body>


        <table class="table table-bordered table-hover">
            <tr>
                <th>ID</th>
                <th>Ad</th>
                <th>Soyad</th>
                <th>Numara</th>
                <th>Mail</th>
                <th>Telefon</th>
                 <th>Dersi</th>
                <th>İşlemler</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                <tr>
                    <td><%#Eval("ogrenciID")%></td>
                    <td><%#Eval("ogrenciAd")%></td>
                    <td><%#Eval("ogrenciSoyad")%></td>
                    <td><%#Eval("ogrenciNumara")%></td>
                    <td><%#Eval("ogrenciMail")%></td>
                    <td><%#Eval("ogrenciTelefon")%></td>
                    <td><%#Eval("ogrenciDers")%></td>
                    <td> <asp:HyperLink NavigateUrl='<%#"~/OgrenciKisiselGuncelle.aspx?ogrenciID="+Eval("ogrenciID") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/Dersler.aspx?ogrenciID="+Eval("ogrenciID") %>' ID="HyperLink3" CssClass="btn btn-warning" runat="server">Ders Basvurusu</asp:HyperLink></td>
                </tr>

                   </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </body>
</asp:Content>
