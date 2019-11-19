<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3.aspx.cs" Inherits="Week6.q3" Theme="Summer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form  ID="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" /><br />
        <asp:Button ID="Button1" runat="server" Text="Change Theme" OnClick="Change"/><br />
        <input id="Text1" type="text" value="This is sample text"/>
    </form>
</body>
</html>
