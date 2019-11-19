<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Electronics.aspx.cs" Inherits="w6q2.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br />
    ELECTRONICS<br /><br />
Mobiles:&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server">
</asp:DropDownList>
<br />
Laptops:&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList2" runat="server">
</asp:DropDownList>
<br />
Printers:&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList3" runat="server">
</asp:DropDownList>
<br />
<br />
</asp:Content>
