<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ems.aspx.cs" Inherits="Emsproject.ems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 854px;
        }
        .auto-style4 {
            text-align: center;
            color: #000000;
            font-size: x-large;
            background-color: #FFFF00;
        }
        .auto-style5 {
            width: 346px;
            font-size: large;
            font-family: "Copperplate Gothic Light";
        }
        .auto-style6 {
            font-weight: normal;
        }
        .auto-style7 {
            width: 346px;
            font-size: large;
            font-family: "Copperplate Gothic Light";
            height: 31px;
        }
        .auto-style8 {
            width: 854px;
            height: 31px;
        }
        .auto-style9 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4" colspan="2"><strong>Electronics Management System</strong></td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong class="auto-style6">Type:</strong></td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddltype" runat="server" Height="17px" OnSelectedIndexChanged="ddltype_SelectedIndexChanged" Width="125px" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong class="auto-style6">Brand:</strong></td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlbrand" runat="server" Height="16px" Width="125px" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong class="auto-style6">Model:</strong></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtmodel" runat="server" Width="367px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong class="auto-style6">Description:</strong></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine" Width="367px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong class="auto-style6">Quantity:</strong></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtquantity" runat="server" TextMode="Number" Width="367px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Price:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtprice" runat="server" TextMode="Number" Width="367px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"><strong class="auto-style6">Color:</strong></td>
                    <td class="auto-style8">
                        <asp:RadioButtonList ID="rblcolor" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Blue</asp:ListItem>
                            <asp:ListItem>Black</asp:ListItem>
                            <asp:ListItem>White</asp:ListItem>
                            <asp:ListItem>Gold</asp:ListItem>
                            <asp:ListItem>Rose Gold</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Assesories:</td>
                    <td class="auto-style8">
                        <asp:CheckBoxList ID="cblass" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Charger</asp:ListItem>
                            <asp:ListItem>wireless mouse</asp:ListItem>
                            <asp:ListItem>Touchpen</asp:ListItem>
                            <asp:ListItem>cover</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td aria-orientation="horizontal" colspan="2">
                        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" Width="162px" />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Reset" runat="server" Text="Reset" Width="162px" OnClick="Reset_Click" />
                    &nbsp;
                        <asp:Button ID="Insert" runat="server" Text="Insert" Width="162px" OnClick="Insert_Click" />
                    &nbsp;&nbsp;
                        <asp:Button ID="Update" runat="server" Text="Update" Width="162px" OnClick="Update_Click" />
                    &nbsp;&nbsp;
                        <asp:Button ID="Delete" runat="server" Text="Delete" Width="162px" OnClick="Delete_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            <strong aria-orientation="vertical">
            <asp:Label ID="Label1" runat="server" CssClass="auto-style9" Text="Label"></asp:Label>
            </strong>
        </p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="567px" AutoGenerateDeleteButton="True" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </form>
</body>
</html>
