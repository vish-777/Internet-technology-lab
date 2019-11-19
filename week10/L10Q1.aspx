<%@ Page Language="C#" AutoEventWireup="true" CodeFile="L10Q1.aspx.cs" Inherits="L10Q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="DS1" runat="server" ConnectionString="<%$ConnectionStrings:database%>" SelectCommand="SELECT * FROM Staff">
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataSourceID="DS1" AllowSorting="true" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:TemplateField HeaderText="Staff Details" SortExpression="Name">
                    <ItemTemplate>
                        <b>Name: </b><%#Eval("Name") %>
                        <br /><b>Age: </b><%#Eval("Age") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Designation" DataField="Designation" />
                <asp:BoundField HeaderText="Salary" DataField="Salary" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
