<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q1.aspx.cs" Inherits="Week8.q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Staff ID: <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Change" /><br />
        <asp:Label ID="Label1" runat="server" /><br />
        <asp:GridView ID="grid" runat="server"></asp:GridView>
        Cities: <asp:ListBox ID="ListBox1" runat="server" /><br />
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Update"/>
    </form>
</body>
</html>
