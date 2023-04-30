using System;
using System.Collections.Generic;
using Survey_app.Model;
using Survey_app.Model.DAO;

namespace Survey_app
{
    public partial class SurveyFirst : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void nextBtn_Click(object sender, EventArgs e)
        {
            //Respondent table info fill
            Respondent respondent = new Respondent();
            respondent.res_email = emailTxtBox.Text;
            respondent.res_Ip = RespondentDAO.GetIPAddress();
            respondent.res_DateStamp = DateTime.Now;

            List<Respondent> respondents = new List<Respondent>();
            respondents.Add(respondent);
            Session["SRespondent"] = respondents;


            //Member table fills as Anonymous default
            string defaultGiven = "Anonymous";
            string defaultLast = "Anonymous";
            DateTime defaultDOB = new DateTime(2020, 01, 01);
            int defaultPhone = 000000;

            Member member = new Member();
            member.givenName = defaultGiven;
            member.lastName = defaultLast;
            member.DOB = defaultDOB;
            member.phoneNumber = defaultPhone.ToString(); ;

            List<Member> memberList = new List<Member>();
            memberList.Add(member);
            Session["SMember"] = memberList;        

            //Move onto question page
            Response.Redirect("SurveyQuestion.aspx");
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Session["userEmail"] = emailTxtBox.Text;
            Response.Redirect("Register.aspx");
        }

        protected void cxlBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Default.aspx");
        }

    }
}