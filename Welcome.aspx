<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Emsproject.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </strong>:</div>
        
        <p>
            <strong>
                <asp:Label ID="lblname" runat="server" Text="name"></asp:Label>
            </strong>
        </p>
        <p>
            <strong>
                <asp:Label ID="Lblphone" runat="server" Text="phone"></asp:Label>
            </strong>
        </p>
        <p>
            <strong>
                <asp:Label ID="lbladd" runat="server" Text="address"></asp:Label>
            </strong>
        </p>
        
    </form>
</body>
</html>
