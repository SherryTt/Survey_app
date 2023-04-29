<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveyFirst.aspx.cs" Inherits="Survey_app.SurveyFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            height: 23px;
            }
        .auto-style4 {
            width: 135px;
        }
        .auto-style6 {
            width: 265px;
        }
        .auto-style7 {
            width: 135px;
            height: 30px;
        }
        .auto-style8 {
            width: 265px;
            height: 30px;
        }
        .auto-style9 {
            height: 30px;
        }
        .auto-style10 {
            width: 135px;
            height: 23px;
        }
        .auto-style11 {
            width: 265px;
            height: 23px;
        }
        .auto-style12 {
            width: 135px;
            height: 29px;
        }
        .auto-style13 {
            width: 265px;
            height: 29px;
        }
        .auto-style14 {
            height: 29px;
        }
        .auto-style15 {
            width: 100%;
            margin-left: 130px;
        }
        .auto-style16 {
            font-size: large;
        }
        .auto-style17 {
            font-size: large;
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: #3333CC">
           <h2>
             <asp:Label ID="Label5" runat="server" style="color: #FFFFFF" Text="AIT Rsearch Online Servey"></asp:Label>
           </h2>
        </div>
            <table class="auto-style15">
                <tr>
                    <td class="auto-style3" colspan="2">
        <asp:Label ID="Label8" runat="server" Text="1.Please enter your email address to start the survey" CssClass="auto-style16"></asp:Label>
                    </td>
                  
                </tr>
                <tr>
                    <td class="auto-style7">
        <asp:Label ID="Label7" runat="server" Text="Email address:"></asp:Label>
                    </td>
                    <td class="auto-style8">
        <asp:TextBox ID="emailTxtBox" runat="server" Height="20px" Width="230px"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
        <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ErrorMessage="Email cannot be empty" style="color: #FF0000" ControlToValidate="emailTxtBox"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td colspan="2">
            <asp:Label ID="Label11" runat="server" Text="2.Would you like to register as a member?" style="font-size: large"></asp:Label></td>
                    <td>
            <asp:Button ID="registerBtn" runat="server" OnClick="registerBtn_Click" Text="Register" Height="25px" Width="155px" style="color: #FFFFFF; font-weight: 700; background-color: #666666" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style17">3.If not... please press Next to start the survey </td>
                    <td class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                    <td class="auto-style13"><asp:Button ID="nextBtn" runat="server" OnClick="nextBtn_Click" Text="NEXT" Height="25px" style="color: #FFFFFF; font-weight: 700; background-color: #666666" Width="155px" /></td>
                    <td class="auto-style14">
         <asp:Button ID="cxlBtn" runat="server" OnClick="cxlBtn_Click" Text="Cancel" Height="25px" style="color: #FFFFFF; font-weight: 700; background-color: #666666" Width="155px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
        </table>
        <br />
    </form>
</body>
</html>
