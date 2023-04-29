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
        .auto-style1 {
            height: 34px;
        }
        .auto-style2 {
            text-align: justify;
            width: 299px;
        }
        .auto-style3 {
            margin-left: 182px;
        }
        .auto-style4 {
            height: 34px;
            width: 299px;
        }
        .auto-style5 {
            width: 299px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div>
             <h2 style="text-align: center; color: #FFFFFF; background-color: #6600CC">
                <asp:Label ID="Label1" runat="server" Text="Member Register"></asp:Label>
            </h2> 
        </div>
        

       <table class="auto-style3">
           <tr>
                <td class="auto-style1">Given name</td>
                <td style="text-align: justify" class="auto-style4"><asp:TextBox ID="givennameTxtBox" runat="server" Height="20px" Width="250px" style="text-align: justify"></asp:TextBox>
                </td>
           </tr>
        
           <tr>
                <td>Last name</td>
                <td style="text-align: justify" class="auto-style5"><asp:TextBox ID="lastnameTxtBox" runat="server" Height="20px" Width="250px"></asp:TextBox>
                </td>
           </tr>
        
           <tr>
                <td>Email address</td>
                <td style="text-align: justify" class="auto-style5"><asp:TextBox ID="emailTxtBox" runat="server" Height="20px" Width="250px"></asp:TextBox>
                </td>
           </tr>
        
           <tr>
                <td>Date of birth</td>
                <td style="text-align: justify" class="auto-style5">
                <asp:TextBox ID="dobTxtBox" runat="server" Height="20px" Width="250px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="../Images/calender.png" Height="28px" Width="26px" OnClick="ImageButton1_Click" ImageAlign="AbsBottom" />
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="White" OnDayRender="Calendar1_DayRender" ></asp:Calendar></td>
              
           </tr>
        
           <tr>
                <td>Phone number</td>
                <td style="text-align: justify" class="auto-style5"><asp:TextBox ID="phoneTxtBox" runat="server" Height="20px" Width="250px"></asp:TextBox>
                </td>
           </tr>
        
           <tr>
                <td></td>
                <td class="auto-style2"><asp:Button ID="registerBtn" runat="server" Height="29px" style="color: #FFFFFF; background-color: #666666" Text="Register" Width="250px" OnClick="registerBtn_Click" /></td>
           </tr>
        </table>
    </form>
    <p style="text-align: right">
    <a href="../Default.aspx">
        <input id="cxlBtn" type="button" value="Cancel" /></a></p>
</body>
</html>
