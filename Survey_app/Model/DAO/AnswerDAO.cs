using System.Collections.Generic;
using System.Data.SqlClient;

namespace Survey_app.Model.DAO
{
    public class AnswerDAO
    {
        public static void InsertAnswer(List<Answer> answers, int respondentId)
        {

            DBmanager db = new DBmanager();
            db.openConnection();

            foreach (Answer answer in answers)
            {
                string query = "INSERT INTO Answer (Answer_text, Choice_id,Respondent_id) VALUES (@a_text,@choice_id,@respondent_id)";
                SqlCommand command = new SqlCommand(query, db.conn);
                command.Parameters.AddWithValue("@a_text", answer.a_text);
                command.Parameters.AddWithValue("@choice_id", answer.choice_id);
                command.Parameters.AddWithValue("@respondent_id", respondentId);
                int rows = command.ExecuteNonQuery();
            }

            db.closeConnection();
        }
    }
}