﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3.aspx.cs" Inherits="Week8.q3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        New price: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Change" OnClick="Change"/><br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
