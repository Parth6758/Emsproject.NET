<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Emsproject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 45%;
        }
        .auto-style2 {
            width: 107px;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="2"><strong>Login Page:</strong></td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Email:</strong></td>
                <td>
                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="Emailvalidate" runat="server" ControlToValidate="Email" ErrorMessage="Invalid email format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Password:</strong></td>
                <td>
                    <asp:TextBox ID="Passsword" runat="server" OnTextChanged="Password_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Passsword" ErrorMessage="Password required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="login1" runat="server" Text="Login" OnClick="login1_Click" />
&nbsp;&nbsp;
        <asp:Button ID="Register" runat="server" Text="Register" />
    </form>
</body>
</html>
