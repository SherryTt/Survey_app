<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="Survey_app.Staff.StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
            width: 258px;
        }
        .auto-style2 {
            text-align: right;
            height: 26px;
            width: 258px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            color: #FF0000;
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
                <td class="auto-style2">USER ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="userIdTextBox" runat="server" Width="240px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="userIdValidator" runat="server" ErrorMessage="User ID is required" ControlToValidate="userIdTextBox" CssClass="auto-style4"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">PASSWORD</td>
                <td>
                    <asp:TextBox ID="userPassTextBox" runat="server" Width="240px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="userPassValidator" runat="server" ErrorMessage="Password is required" ControlToValidate="userPassTextBox" CssClass="auto-style4"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="loginBtn" runat="server" Text="Login" Width="240px" OnClick="loginBtn_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Label ID="errorLabel" runat="server" CssClass="auto-style4"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
