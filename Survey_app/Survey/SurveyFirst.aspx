<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveyFirst.aspx.cs" Inherits="Survey_app.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: #3333CC">
           <h2>
             <asp:Label ID="Label5" runat="server" style="color: #FFFFFF" Text="AIT Rsearch Online Servey:User information"></asp:Label>
           </h2>
        </div>
            <br />
            <br />
        <p style="text-align:justify;margin-left:50px;">
            <asp:Label ID="Label4" runat="server" Text="Would you like to register as a member?" style="font-size: large"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="registerBtn" runat="server" OnClick="registerBtn_Click" Text="Register" Height="28px" Width="184px" style="color: #FFFFFF; font-weight: 700; background-color: #666666" />
        </p>

            <br />
            <br />
        <p style="text-align:justify;margin-left:50px" class="auto-style1">
            If you wish to continue without registering </p>
        <p style="text-align:justify;margin-left:50px">
        <asp:Label ID="Label2" runat="server" Text="Please enter your email address to start the survey"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email address:"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="emailTxtBox" runat="server" OnTextChanged="TextBox1_TextChanged" Height="20px" Width="230px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ErrorMessage="Email cannot be empty" style="color: #FF0000" ControlToValidate="emailTxtBox"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style="text-align:justify;margin-left:50px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <p style=margin-left:50px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="nextBtn" runat="server" OnClick="nextBtn_Click" Text="NEXT" Height="25px" style="color: #FFFFFF; font-weight: 700; background-color: #666666" Width="155px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="cxlBtn" runat="server" OnClick="cxlBtn_Click" Text="Cancel" Height="25px" style="color: #FFFFFF; font-weight: 700; background-color: #666666" Width="155px" />
        </p>
        <br />
        <div style="text-align:right">
       </div>
    </form>
</body>
</html>
