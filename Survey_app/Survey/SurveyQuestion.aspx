<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveyQuestion.aspx.cs" Inherits="Survey_app.SurveyQuestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 267px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <h2 style="text-align: center; color: #FFFFFF; background-color: #6600CC">
                <asp:Label ID="Label1" runat="server" Text="AIT Online Survey"></asp:Label>
            </h2>
        </div>


         <table style="width:100%;">
             <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
             </tr>
             <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                 <asp:Label ID="questionLbl" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
             </tr>
              <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
             </tr>
              <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
             </tr>
             <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                 <asp:PlaceHolder ID="answerPhd" runat="server"></asp:PlaceHolder>
                </td>
                <td>&nbsp;</td>
             </tr>
              <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
             </tr>
              <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td>
                     <asp:Button ID="nextBtn" runat="server" Text="Next" OnClick="NextBtnClick" style="color: #FFFFFF; background-color: #0033CC; margin-right:100px" Width="217px" />
                 </td>
                <td>&nbsp;</td>
             <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
             </tr>
             </tr>
             <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td>
                   <asp:Label ID="alertLbl" runat="server" style="font-weight: 700"></asp:Label>
                 </td>
                 <td>&nbsp;</td>
             </tr>
              <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
             </tr>
              <tr>
                 <td class="auto-style1">&nbsp;</td>
                 <td></td>
                 <td>
         <asp:Button ID="cxlBtn" runat="server" Text="Cancel" OnClick="cxlBtn_Click" />
                  </td>
             </tr>
         </table>

    </form>
</body>
</html>
