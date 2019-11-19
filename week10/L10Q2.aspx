<%@ Page Language="C#" AutoEventWireup="true" CodeFile="L10Q2.aspx.cs" Inherits="L10Q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="DS1" runat="server" ConnectionString="<%$ConnectionStrings:database%>" SelectCommand="SELECT * FROM Authors" UpdateCommand="UPDATE Authors SET FirstName=@FirstName,CopiesSold=@CopiesSold WHERE Id=@Id">
        </asp:SqlDataSource>
        <asp:GridView DataKeyNames="Id" ID ="GridView1" runat="server" AllowPaging="true" PageSize="3" HeaderStyle-BackColor="Green" HeaderStyle-ForeColor="Red" DataSourceID="DS1" AutoGenerateColumns="false">
            <Columns>
                <asp:CommandField ButtonType="Link" ShowEditButton="true" />
                <asp:TemplateField HeaderText="Id">
                    <ItemTemplate>
                        <%#Eval("Id") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        FirstName: <%#Eval("FirstName")%><br />
                        LastName: <%#Eval("LastName") %>
                    </ItemTemplate> 
                    <EditItemTemplate>
                        FirstName: <asp:TextBox Text='<%#Bind("FirstName") %>' runat="server" ID="txtFirstName"/><br />
                        LastName: <%#Eval("LastName") %>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book Title">
                    <ItemTemplate>
                        <%#Eval("Title") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Genre">
                    <ItemTemplate>
                        <%#Eval("Genre") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Copies Sold" DataField="CopiesSold" SortExpression="CopiesSold" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
