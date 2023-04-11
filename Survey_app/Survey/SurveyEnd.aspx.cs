using System;
using System.Collections.Generic;
using Survey_app.Model;
using System.Data.SqlClient;

namespace Survey_app
{
    public partial class SurveyEnd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBmanager db = new DBmanager();
            db.conn.Open();

            // 2. Retrieve the answers from the session
            List<Answer> answers = (List<Answer>)Session["Answers"];
            var rows = 0;
            // 3. Insert each answer into the database
            foreach (Answer answer in answers)
            {
                string query = "INSERT INTO Answer (Answer_text, Choice_id) VALUES (@a_text,@choice_id)";
                SqlCommand command = new SqlCommand(query, db.conn);
                command.Parameters.AddWithValue("@a_text", answer.a_text);
                command.Parameters.AddWithValue("@choice_id", answer.choice_id);
              //  sqlCommand.Parameters.AddWithValue("@respondent_id", answer.respondent_id);
                rows += command.ExecuteNonQuery();
            }

            // 4. Close the database connection
            db.closeConnection();
        }
    }
}

