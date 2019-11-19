﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Select the sales_id whose details you want to view:" /> 
            <br /><br />
            <asp:DropDownList ID="ddl" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_SelectedIndexChanged"/>
            <br /><br />
            <asp:GridView ID="grid" runat="server" AutoGenerateColumns="false" CellPadding="5" CellSpacing="5" BorderColor="black" BorderWidth="3" AllowSorting="true" >
            <Columns>
            <asp:BoundField DataField="item_name" HeaderText="Name" SortExpression="item_name" HeaderStyle-BackColor="Gray" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"/>
            <asp:TemplateField HeaderText = "Details" HeaderStyle-BackColor="Gray" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White">
            <ItemTemplate>
                <b > Amount:</b>
                <%# Eval("item_amt") %>
                <br />
                <b > Quantity:</b>
                <%# Eval("qty") %>
                <br />
            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
