<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q1.aspx.cs" Inherits="Week6.q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Choose a candidate: <asp:DropDownList ID="dd1" runat="server" />
        <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="dd1" ErrorMessage="Please select candidate" /><br />
        House: <asp:RadioButtonList ID="rbl1" runat="server" />
        <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="rbl1" ErrorMessage="Please select house" /><br />
        Class: <asp:TextBox ID="tb1" runat="server" />
        <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="tb1" ErrorMessage="Please enter class" />
        <asp:RangeValidator ID="rv1" runat="server" ControlToValidate="tb1" Type="Integer" MinimumValue=6 MaximumValue=12 ErrorMessage="Please enter class between 6 and 12" /><br />
        EmailID: <asp:TextBox ID="tb2" runat="server" />
        <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="tb2" ErrorMessage="Please enter email" />
        <asp:RegularExpressionValidator ID="rev1" runat="server" ControlToValidate="tb2" ValidationExpression=".+@.+" ErrorMessage="Incorrect email" /><br />
        Parent Contact: <asp:TextBox ID="tb3" runat="server" />
        <asp:CustomValidator ID="cv1" runat="server" ControlToValidate="tb3" ValidateEmptyText="false" OnServerValidate="Validate" ErrorMessage="Please enter valid contact" /><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Submit" /><br />
        <asp:ValidationSummary ID="vs1" runat="server" />
    </form>
    <asp:Label ID="Label1" runat="server" />
</body>
</html>
