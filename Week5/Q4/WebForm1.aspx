<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="w5q4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Username:&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <br /><br />
        Password:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />
        <div style="margin-left: 80px">
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>

