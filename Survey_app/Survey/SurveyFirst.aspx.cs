using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Survey_app
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void nextBtn_Click(object sender, EventArgs e)
        {
            Session["userEmail"] = emailTxtBox.Text;
            Response.Redirect("SurveyQuestion.aspx");
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void cxlBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Default.aspx");
        }
    }
}