<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="w6q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            STUDENT HOUSE PRESIDENT ELECTION<br />
            <br />
            
            Choose Candidate:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RFV1" runat="server" ErrorMessage="Select a Candidate" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
            
            <br />
            <br />

            House:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            </asp:RadioButtonList>
            <br />
            <asp:RequiredFieldValidator ID="RFV2" runat="server" ErrorMessage="House can't be blank" ControlToValidate="RadioButtonList1"></asp:RequiredFieldValidator>

            <br />
            <br />
            <br />


            Class:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RFV3" runat="server" ErrorMessage="Class can't be blank" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RV1" runat="server" ErrorMessage=" Only Class 6 to Class 12 allowed" ControlToValidate="TextBox1" MaximumValue="12" MinimumValue="6" Type="Integer"></asp:RangeValidator>
            <br />
            <br />


            Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RFV4" runat="server" ErrorMessage="Email can't be blank" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="REV1" runat="server" ErrorMessage=" Enter email in correct format: 'abc@gef.com'" ControlToValidate="TextBox2" ValidationExpression=".+@.+"></asp:RegularExpressionValidator>
            <br />
            <br /> 


            Parent&#39;s contact no:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CV1" runat="server" ErrorMessage="Try a string that starts with 6,7,8,9." ValidateEmptyText="False" ControlToValidate="TextBox3" onServerValidate="Phone_number_validation" />
            <br />
            <br />
            <br />




&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
        </div>         
       
    </form>
</body>
</html>
