using System;
using System.Collections.Generic;
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

            //Pass inputted email from previous page
            emailTxtBox.Text = Session["userEmail"].ToString();

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //Controll displaying calender image
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
            //Respondent table info fills
            Respondent respondent = new Respondent();
            respondent.res_email = emailTxtBox.Text;
            respondent.res_Ip = RespondentDAO.GetIPAddress();
            respondent.res_DateStamp = DateTime.Now;
            List<Respondent> respondents = new List<Respondent>();
            respondents.Add(respondent);
            Session["SRespondent"] = respondents;


            //Member table info filles
            Member member = new Member();
            member.givenName = givennameTxtBox.Text;
            member.lastName = lastnameTxtBox.Text;
            member.DOB = DateTime.Parse(dobTxtBox.Text);
            member.phoneNumber = phoneTxtBox.Text;

            List<Member> memberList = new List<Member>();
            memberList.Add(member);
            Session["SMember"] = memberList;
           
            //Move onto question page
            Response.Redirect("SurveyQuestion.aspx");
        }

        //Calender select controll
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