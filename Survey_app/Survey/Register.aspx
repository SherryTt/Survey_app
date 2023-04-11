<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Survey_app.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
        #cxlBtn {
            height: 27px;
            width: 108px;
            font-weight: 700;
            color: #FFFFFF;
            background-color: #666666;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div  background-color: #3333CC">
            <h2>
                <asp:Label ID="Label1" runat="server" style="color: #FFFFFF" Text="Register for a member"></asp:Label>
            </h2>
        </div>

       <table>
           <tr>
                <td>Given name</td>
                <td style="text-align: justify"><asp:TextBox ID="givennameTxtBox" runat="server" Height="20px" Width="310px" style="text-align: justify"></asp:TextBox></td>
           </tr>
        
           <tr>
                <td>Last name</td>
                <td style="text-align: justify"><asp:TextBox ID="lastnameTxtBox" runat="server" Height="20px" Width="310px"></asp:TextBox></td>
           </tr>
        
           <tr>
                <td>Email address</td>
                <td style="text-align: justify"><asp:TextBox ID="emailTxtBox" runat="server" Height="20px" Width="310px"></asp:TextBox></td>
           </tr>
        
           <tr>
                <td>Date of birth</td>
                <td style="text-align: justify">
                <asp:TextBox ID="dobTxtBox" runat="server" Height="20px" Width="310px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="Images/calender.png" Height="28px" Width="26px" OnClick="ImageButton1_Click" ImageAlign="AbsBottom" />
                <asp:Calendar ID="Calendar1" runat="server" Height="73px" Width="173px" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar></td>
              
           </tr>
        
           <tr>
                <td>Phone number</td>
                <td style="text-align: justify"><asp:TextBox ID="phoneTxtBox" runat="server" Height="20px" Width="310px"></asp:TextBox></td>
           </tr>
        
           <tr>
                <td></td>
                <td><asp:Button ID="registerBtn" runat="server" Height="29px" style="color: #FFFFFF; background-color: #666666" Text="Register" Width="418px" OnClick="registerBtn_Click" /></td>
           </tr>
        </table>
    </form>
    <p style="text-align: right">
    <a href="../Default.aspx">
        <input id="cxlBtn" type="button" value="Cancel" /></a></p>
</body>
</html>
