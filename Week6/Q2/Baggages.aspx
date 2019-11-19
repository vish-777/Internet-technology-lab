<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Baggages.aspx.cs" Inherits="w6q2.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br />
    BACKPACKS<br />
    <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl="trolleybag.jpg" />&nbsp&nbsp&nbsp&nbsp
    <asp:Image ID="Image2" runat="server" ImageUrl="~/laptopbag.jpg" Height="200px" />&nbsp&nbsp&nbsp&nbsp
    <asp:Image ID="Image3" runat="server" Height="200px" ImageUrl="~/backpack.jpg" /><br />

</asp:Content>