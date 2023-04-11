<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Survey_app.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #startBtn {
            height: 31px;
            width: 331px;
            }
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            color: #FFFFFF;
            font-size: large;
            background-color: #666666;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div style="text-align: center; background-color: #3333CC">
            <h2>
                <asp:Label ID="Label3" runat="server" style="color: #FFFFFF" Text="AIT Rsearch Online Servey"></asp:Label>
            </h2>
        </div>
        '<div style="text-align: right" >
          <a href="">
        <asp:Button ID="adminBtn" runat="server" Text="ADMIN" style="text-align: right" />
        </a></div>
         <div class="auto-style1"style="text-align: left" >
        <br />
        <asp:Label ID="Label2" runat="server" Text="This is a survey for researching a user needs regarding a banks and newspaper.This survey will take around 10 minutes to complete."></asp:Label>
        <br />
        <br />
         </div>
        <div>
        <p style="text-align: center">
        <a href="/Survey/SurveyFirst.aspx">
            <input id="startBtn" type="button" value="Survey Start" class="auto-style2" /><span class="auto-style2"> </span>

        </a></p>
       </div>
    </form>
</body>
</html>
