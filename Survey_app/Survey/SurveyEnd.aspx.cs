using System;
using System.Collections.Generic;
using Survey_app.Model;
using Survey_app.Model.DAO;

namespace Survey_app
{
    public partial class SurveyEnd : System.Web.UI.Page
    {
        Member member;
        Respondent respondent;
        Answer answer;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            
                //Insert Member table
                List<Member> member = (List<Member>)Session["SMember"];
                int memberId = RespondentDAO.InsertMember(member);
           
                //Insert Respondent table
                List<Respondent> respondentList = (List<Respondent>)Session["SRespondent"];
                int respondentId = RespondentDAO.InsertRespondent(respondentList,memberId);

                List<Answer> answer = (List<Answer>)Session["Answers"];
                AnswerDAO.InsertAnswer(answer,respondentId); 


            //Add respondent ID into Answer session
            /*
            respondent.res_id = answer.respondent_id;
            List<Answer> answers = new List<Answer>();
            answers.Add(answer);
            Session["Answers"] = answers;
            List<Answer> answers1 = (List<Answer>)Session["Answers"];
            AnswerDAO.InsertAnswer(answers1);*/


        }
    }
}

