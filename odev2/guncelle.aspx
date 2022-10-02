<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="guncelle.aspx.cs" Inherits="odev2.guncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="w-100" style="margin-left:400px;">
    <tr>
        <td class="text-left">&nbsp;</td>
        <td class="text-left">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>
            <asp:Label ID="Label2" runat="server" Text="Türü"></asp:Label>
            </strong></td>
        <td class="auto-style7"><strong>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style2"><strong>
            <asp:Label ID="Label3" runat="server" Text="Adı"></asp:Label>
            </strong></td>
        <td class="auto-style2"><strong>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style8"><strong>
            <asp:Label ID="Label4" runat="server" Text="Tarih"></asp:Label>
            </strong></td>
        <td class="auto-style8"><strong>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style3"><strong>Öğrenci Sayısı</strong></td>
        <td class="auto-style3"><strong>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>
            <asp:Label ID="Label6" runat="server" Text="İçerik"></asp:Label>
            </strong></td>
        <td class="auto-style6"><strong>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style5"><strong>Eğitim Kodu</strong></td>
        <td class="auto-style5"><strong>
            <asp:TextBox ID="TextBox6" runat="server" Enabled="False"></asp:TextBox>
            </strong></td>
    </tr>
    <tr>
        <td class="text-left">&nbsp;</td>
        <td class="text-left"><strong>
            <asp:Button ID="Button1" runat="server" Text="Güncelle" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp; </strong>
            <asp:Label ID="Label7" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="text-left">&nbsp;</td>
        <td class="text-left">&nbsp;</td>
    </tr>
</table>

</asp:Content>
