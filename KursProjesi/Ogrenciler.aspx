<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ogrenciler.aspx.cs" Inherits="KursProjesi.Ogrenciler1" %>

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
                <th>Telefon </th>
                 <th>Dersi</th>
                <th>Kalan Para </th>
                <th>Son Ödenen</th>
                <th>Son Ödenen Tarih</th>
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
                    <td><%#Eval("ogrenciBorc")%></td>
                    <td><%#Eval("ogrenciKalan")%></td>
                    <td><%#Eval("ogrenciTime")%></td>
                   
                    <td>
                        <asp:HyperLink NavigateUrl='<%#"~/OgrenciSil.aspx?ogrenciID="+Eval("ogrenciID") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                        <asp:HyperLink NavigateUrl='<%#"~/OgrenciGuncelle.aspx?ogrenciID="+Eval("ogrenciID") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        <asp:HyperLink NavigateUrl='<%#"~/OdemeSayfasi.aspx?ogrenciID="+Eval("ogrenciID") %>' ID="HyperLink3" CssClass="btn btn-success" runat="server">Ödeme</asp:HyperLink>
                    </td>

                </tr>
                   </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </body>
</asp:Content>
