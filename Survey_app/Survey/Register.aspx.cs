using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey_app.Model;
using Survey_app.Model.DAO;

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


            emailTxtBox.Text = Session["userEmail"].ToString();
                

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
            Calendar1.Attributes.Add("style", "position:absolute");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dobTxtBox.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.Visible = false;
          
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {

            Respondent respondent = new Respondent();
            respondent.res_email = emailTxtBox.Text;
            respondent.res_Ip = RespondentDAO.GetIPAddress();
            respondent.res_DateStamp = DateTime.Now;
            List<Respondent> respondents = new List<Respondent>();
            respondents.Add(respondent);
            Session["SRespondent"] = respondents;


            Member member = new Member();
            member.givenName = givennameTxtBox.Text;
            member.lastName = lastnameTxtBox.Text;
            member.DOB = DateTime.Parse(dobTxtBox.Text);
            member.phoneNumber = phoneTxtBox.Text;

            
            if (Session["SMember"] != null)
            {
                List<Member> memberList = (List<Member>)Session["SMember"];
                memberList.Add(member);
                Session["SMember"] = memberList;
            }
            else
            {
                List<Member> memberList = new List<Member>();
                memberList.Add(member);
                Session["SMember"] = memberList;
            }

            Response.Redirect("SurveyQuestion.aspx");
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Gray;
            }
        }
    }
}