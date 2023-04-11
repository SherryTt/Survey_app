using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey_app;

namespace Survey_app
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
          //  Calendar1.Attributes.Add("style", "position:absolute");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dobTxtBox.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.Visible = false;
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            String email = emailTxtBox.Text;
            String givenName = givennameTxtBox.Text;
            String lastName = lastnameTxtBox.Text;
            String dob = dobTxtBox.Text;
            String phone = phoneTxtBox.Text;

            Response.Redirect("SurveyQuestion.aspx");
        }
    }
}