<%@ Page Title="" Language="C#" MasterPageFile="~/q4.Master" AutoEventWireup="true" CodeBehind="q4a.aspx.cs" Inherits="Week6.q4a" Theme="Summer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="Change" AutoPostBack="true" /><br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Submit" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c2" runat="server">
    <asp:Label ID="Label1" runat="server" />
</asp:Content>
