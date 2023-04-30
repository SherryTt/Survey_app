<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffSearch.aspx.cs" Inherits="Survey_app.AdminSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            
        }
        .auto-style2 {
            width: 121px;
        }
        .auto-style3 {
            width: 121px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 190px;
        }
        .auto-style7 {
            width: 190px;
            height: 23px;
        }
        .auto-style8 {
            width: 210px;
        }
        .auto-style9 {
            width: 210px;
            height: 23px;
        }

        
        .auto-style10 {
            height: 31px;
        }

        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align: center; color: #FFFFFF; background-color: #6600CC">
                <asp:Label ID="Label1" runat="server" Text="Search Survey Respondents"></asp:Label>
            </h2>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
        <asp:Button ID="LogoutBtn" runat="server" Height="23px" style="color: #FFFFFF; background-color: #666666" Text="Logout" Width="83px" OnClick="LogoutBtn_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="Label11" runat="server" Text="First name :"></asp:Label>
                </td>
                <td class="auto-style6">
            <asp:TextBox ID="firstnameTxtBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">
            <asp:Label ID="Label3" runat="server" Text="State/Territory :"></asp:Label>
                </td>
                <td class="auto-style2">
            <asp:DropDownList ID="StateDropDownList" runat="server" Height="16px" Width="80px">
                <asp:ListItem>-Select-</asp:ListItem>
                <asp:ListItem Value="1">WA</asp:ListItem>
                <asp:ListItem Value="2">QLD</asp:ListItem>
                <asp:ListItem Value="3">NSW</asp:ListItem>
                <asp:ListItem Value="4">VIC</asp:ListItem>
                <asp:ListItem Value="5">SA</asp:ListItem>
                <asp:ListItem Value="6">NT</asp:ListItem>
                <asp:ListItem Value="7">TAS</asp:ListItem>
            </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="Label4" runat="server" Text="Last name :"></asp:Label>
                </td>
                <td class="auto-style6">
            <asp:TextBox ID="lastnameTxtBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">
            <asp:Label ID="Label5" runat="server" Text="Bank :"></asp:Label>
                </td>
                <td class="auto-style2">
            <asp:DropDownList ID="BankDropDownList" runat="server">
                <asp:ListItem>-Select-</asp:ListItem>
                <asp:ListItem Value="1">NAB</asp:ListItem>
                <asp:ListItem Value="2">Commonwealth bank</asp:ListItem>
                <asp:ListItem Value="3">Westpac</asp:ListItem>
                <asp:ListItem Value="4">ANZ</asp:ListItem>
                <asp:ListItem Value="5">Bendigo bank</asp:ListItem>
            </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="Label6" runat="server" Text="Gender :"></asp:Label>
                </td>
                <td class="auto-style6">
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Male" GroupName="Gender" />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Female" GroupName="Gender" />
                </td>
                <td class="auto-style8">
            <asp:Label ID="Label7" runat="server" Text="Bank services :"></asp:Label>
                </td>
                <td class="auto-style2">
            <asp:DropDownList ID="ServiceDropDownList" runat="server">
                <asp:ListItem>-Select-</asp:ListItem>
                <asp:ListItem Value="1">Internet Banking</asp:ListItem>
                <asp:ListItem Value="2">Home Loan</asp:ListItem>
                <asp:ListItem Value="3">Credit card</asp:ListItem>
                <asp:ListItem Value="4">Share Investment</asp:ListItem>
            </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="Label8" runat="server" Text="Age range :"></asp:Label>
                </td>
                <td class="auto-style6">
            <asp:DropDownList ID="AgeDropDownList" runat="server" >
                <asp:ListItem>-Select-</asp:ListItem>
                <asp:ListItem Value="1">18-25</asp:ListItem>
                <asp:ListItem Value="2">26-35</asp:ListItem>
                <asp:ListItem Value="3">36-45</asp:ListItem>
                <asp:ListItem Value="4">46-55</asp:ListItem>
                <asp:ListItem Value="5">Other</asp:ListItem>
            </asp:DropDownList>
                </td>
                <td class="auto-style8">
            <asp:Label ID="Label9" runat="server" Text="Newspaper :"></asp:Label>
                </td>
                <td class="auto-style2">
            <asp:DropDownList ID="NewsPDropDownList" runat="server">
                <asp:ListItem>-Select-</asp:ListItem>
                <asp:ListItem Value="1">Property</asp:ListItem>
                <asp:ListItem Value="2">Sport</asp:ListItem>
                <asp:ListItem Value="3">Financial</asp:ListItem>
                <asp:ListItem Value="4">Entertaiment</asp:ListItem>
                <asp:ListItem Value="5">Lifestyle</asp:ListItem>
                <asp:ListItem Value="6">Travel</asp:ListItem>
                <asp:ListItem Value="7">Politics</asp:ListItem>
            </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style7"></td>
                <td class="auto-style9"></td>
                <td class="auto-style3"></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style7"></td>
                <td class="auto-style9"></td>
                <td class="auto-style3"></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td colspan="5" style="text-align:center" class="auto-style10">
                <asp:Button ID="searchBtn" runat="server" Height="27px" style="color: #FFFFFF; background-color: #666666" Text="SEARCH" Width="522px" OnClick="searchBtn_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style7"></td>
                <td class="auto-style9"></td>
                <td class="auto-style3"></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="Label13" runat="server" Text="Search result ..."></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="5">
                <asp:GridView ID="GridView" runat="server"></asp:GridView>
                </td>
            </tr>
            </table>
    </form>
</body>
</html>
