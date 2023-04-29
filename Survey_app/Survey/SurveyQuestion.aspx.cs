using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Survey_app.Model;
using Survey_app.Model.DAO;

namespace Survey_app
{
    public partial class SurveyQuestion : System.Web.UI.Page
    {

        /*Hi Kriss
        I have done the code so far
        1.Display the question in order
        2.Only few session answer insert to DB ... 
                -> I have issue with inserting the text answer which doesn't have choice_id as well as when user skip the answer 
        3.Staff serching page
        4.User register page

        Thank you
        */


        
        Question question;
        Choice choice;
        Button skipBtn;
        List<Choice> choices;
        List<Choice> choices1;
        TextBox txtAnswer;
        CheckBoxList checkbox;
        DropDownList dropdown;
        RadioButtonList radioButton;
        int questionId;
        int NQuestionId;
        int txtchoice_id;
        string choice_txt;


        protected void Page_Load(object sender, EventArgs e)
        {
            int nextQID = 2;


            // Controll the question order
            if((Session["NextQID"] != null) &&((int)Session["NextQID"] == 12))
            {
                //leads to end page
                Response.Redirect("SurveyEnd.aspx");
            }
            else if (Session["NextQID"] != null)
            {
                //Continue the QID from previous session
                nextQID =(int)Session["NextQID"];
            }
            else if(Session["NextQID"] == null)
            {   
                //Leads to the Initial question num 2
                Session["NextQID"] = nextQID;
            }


            // Populate the question and choice 
            question = QuestionDAO.GetQuestionById(nextQID);
            choices = QuestionDAO.GetChoices(nextQID);
            
           

            //This controll leading the page to the end or else
            try
            {
                if (question == null)
                {
                    // leads to end of servey
                }
                else
                {
                    //Question lbl set
                    questionLbl.Text = question.q_text;

                    //Answer PHD set depends on q_type
                    switch (question.GetQ_type())
                    {
                        //TEXT
                        case "TextBox":
                            //For gettint choice id from choices list and asign the value
                            foreach (var choice1 in choices)
                            {
                                var itembox = new ListItem(choice1.choice_text, choice1.choice_id.ToString());
                                txtchoice_id = choice1.choice_id;
                            }

                            txtAnswer = new TextBox();
                            txtAnswer.Attributes["questionId"] = question.q_id.ToString();
                            txtAnswer.ID = "TextA";
                            answerPhd.Controls.Add(txtAnswer);
                            Session["CurrentQID"] = question.q_id;
                            break;

                        //CheckBox
                        case "CheckBox":
                            checkbox = new CheckBoxList();
                            checkbox.Attributes["questionId"] = question.q_id.ToString();
                            checkbox.ID = "CheckA";
                            foreach (var choice1 in choices)
                            {
                                var checkBox = new ListItem(choice1.choice_text,choice1.choice_id.ToString());
                                checkbox.Items.Add(checkBox);
                            }
                            answerPhd.Controls.Add(checkbox);
                            Session["CurrentQID"] = question.q_id;
                            break;

                        //RadioButton
                        case "RadioButton":
                            radioButton = new RadioButtonList();
                            radioButton.Attributes["questionId"] = question.q_id.ToString();
                            radioButton.ID = "RadioA";
                            foreach (var choice1 in choices)
                            {
                                var radioBtn = new ListItem(choice1.choice_text,choice1.choice_id.ToString());
                                radioButton.Items.Add(radioBtn);
                            }
                            answerPhd.Controls.Add(radioButton);
                            Session["CurrentQID"] = question.q_id;
                            break;

                        //DropDown
                        case "DropDown":
                            dropdown = new DropDownList();
                            dropdown.Attributes["questionId"] = question.q_id.ToString();
                            dropdown.ID = "DropA";
                            foreach (var choice1 in choices)
                            {
                                var item = new ListItem(choice1.choice_text,choice1.choice_id.ToString());
                                dropdown.Items.Add(item);
                            }
                            answerPhd.Controls.Add(dropdown);
                            Session["CurrentQID"] = question.q_id;
                            break;
                            
                        default:
                            txtAnswer = new TextBox();
                            txtAnswer.ID = "";
                            answerPhd.Controls.Add(txtAnswer);
                            Session["CurrentQID"] = question.q_id;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                // error msg
                throw;
            }
        }







        /// <summary>
        /// Click next button trigger to selected answer to be saved in session and find nextQID depends on the answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void NextBtnClick(object sender, EventArgs e)
        {
       
            //Controll question order
            NQuestionId = (int)Session["NextQID"];
            Session["NextQID"] = NQuestionId + 1;

            question = QuestionDAO.GetQuestionById(NQuestionId);
            

            switch (question.GetQ_type())
            {
                //TEXT
                case "TextBox":
                    if (txtAnswer != null)
                    {
                        Answer answer = new Answer();
                        answer.a_text = txtAnswer.Text;
                        answer.choice_id = txtchoice_id;
                        answer.question_id =Int16.Parse(txtAnswer.Attributes["questionId"]);
                        Session["NextQID"] = question.q_order;
                        int choiceID = answer.choice_id;
                        choice = QuestionDAO.GetQuestionOrder(choiceID);
                        Session["NextQID"] = choice.question_order;

                        // Storing answers in a Session
                        if (Session["Answers"] != null)
                        {
                            // Store answer in the same session
                            List<Answer> answers = (List<Answer>)Session["Answers"];
                            answers.Add(answer);
                            Session["Answers"] = answers;
                        }
                        else
                        {
                            // Store the first answer in a new created List
                            List<Answer> answers = new List<Answer>();
                            answers.Add(answer);
                            Session["Answers"] = answers;
                        }

                    }
                    break;

                //CHECK BOX
                case "CheckBox":

                    if (checkbox.SelectedValue != null)
                    {
                        Answer answer = new Answer();
                        String selectedItems = "";
                            
                            foreach (ListItem checkedItem in checkbox.Items)
                            {
                                if (checkedItem.Selected)
                                {
                                selectedItems += checkedItem.Text + "',";
                                }
                            answer.question_id = Int16.Parse(checkbox.Attributes["questionId"]);
                            }
                       
                        selectedItems = selectedItems.TrimEnd(new char[] { ',' });
                        answer.a_text = selectedItems;
                        answer.choice_id = Int16.Parse(checkbox.SelectedValue);
                        int choiceID = answer.choice_id;
                        choice = QuestionDAO.GetQuestionOrder(choiceID);
                        Session["NextQID"] = choice.question_order;


                        if (Session["Answers"] != null)
                        {
                            List<Answer> answers = (List<Answer>)Session["Answers"];
                            answers.Add(answer);
                            Session["Answers"] = answers;
                        }
                        else
                        {
                            List<Answer> answers = new List<Answer>();
                            answers.Add(answer);
                            Session["Answers"] = answers;
                        }
                    }
                    break;

                //RADIO BUTTON
                case "RadioButton":

                    if (radioButton.SelectedValue != null)
                    {
                        Answer answer = new Answer();
                        answer.a_text = radioButton.SelectedItem.Text;
                        answer.choice_id = Int16.Parse(radioButton.SelectedValue);
                        answer.question_id = Int16.Parse(radioButton.Attributes["questionId"]);
                        int choiceID =answer.choice_id;
                        choice = QuestionDAO.GetQuestionOrder(choiceID);
                        Session["NextQID"] = choice.question_order;
                        
                        // Storing answers in a Session
                        if (Session["Answers"] != null)
                        {
                            List<Answer> answers = (List<Answer>)Session["Answers"];
                            answers.Add(answer);
                            Session["Answers"] = answers;
                        }
                        else
                        {
                            List<Answer> answers = new List<Answer>();
                            answers.Add(answer);
                            Session["Answers"] = answers;
                        }
                    }
                    break;

                //DROP DOWN
                case "DropDown":
                  
                    if (dropdown.SelectedValue != null)
                    {
                        Answer answer = new Answer();
                        answer.a_text = dropdown.SelectedItem.Text;
                        answer.choice_id = Int16.Parse(dropdown.SelectedValue);
                        answer.question_id = Int16.Parse(dropdown.Attributes["questionId"]);

                        if (Session["Answers"] != null)
                        {
                            List<Answer> answers = (List<Answer>)Session["Answers"];
                            answers.Add(answer);
                            Session["Answers"] = answers;
                        }
                        else
                        {
                            List<Answer> answers = new List<Answer>();
                            answers.Add(answer);
                            Session["Answers"] = answer;
                        }
                    }
                    break;

                    default:
                    break;
            }

            Response.Redirect("SurveyQuestion.aspx");
        }


        /// <summary>
        /// Click skip button saves answer as null in session 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*
        protected void SkipButton_Click(object sender, EventArgs e)
        {
            int num = 1;
            

            if(Session["first"] == null)
            {
                choice_txt = "skip";
            }
            else if(Session["first"] != null)
            {
                Session["first"] = num++;
                choice_txt = "skip" + Session["first"].ToString();
            }
            questionId = (int)Session["CurrentQID"];
            Choice choices1 = QuestionDAO.createSkipChoice(choice_txt,questionId) ;
                
            Answer answer = new Answer();
            answer.a_text = choice_txt;
            answer.choice_id = choices1.choice_id;
            answer.question_id = questionId;

            // Storing null answers in a Session
            if (Session["Answers"] != null)
            {
                List<Answer> answers = (List<Answer>)Session["Answers"];
                answers.Add(answer);
                Session["Answers"] = answers;
            }
            else
            {
                List<Answer> answers = new List<Answer>();
                answers.Add(answer);
                Session["Answers"] = answer;
            }
            Response.Redirect("SurveyQuestion.aspx");
        }*/

        protected void cxlBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Default.aspx");
        }
    }
}

