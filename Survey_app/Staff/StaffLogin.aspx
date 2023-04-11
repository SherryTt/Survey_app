<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="Survey_app.Staff.StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align: center; color: #FFFFFF; background-color: #6600CC">
                <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">USER ID</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">PASSWORD</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="loginBtn1" runat="server" Text="Login" Width="240px" OnClick="loginBtn1_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
