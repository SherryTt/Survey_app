using System.Collections.Generic;
using System.Data.SqlClient;


namespace Survey_app.Model.DAO
{
    public class QuestionDAO
    {

        //Generate the question by questionId
        public static Question GetQuestionById(int questionID)
        {
            DBmanager db = new DBmanager();
            db.openConnection();
            Question question = null;

            // Execute the SQL Command
           string query = @"SELECT * FROM Question WHERE Question_id = " + questionID;
            SqlCommand command = new SqlCommand(query, db.conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                question = new Question();
                //Fill the Question object with the correspondent values 
                question.q_id = (int)reader["Question_id"];
                question.q_text = reader["Question_text"].ToString();
                question.q_type = (int)reader["Question_type"];
                question.q_order = (int)reader["Question_order"];
            }
            db.closeConnection();
            return question;        
    }




        //Manage question order by choiceId to be able to be assign right next question 
        public static Choice GetQuestionOrder(int choiceId)
        {
            DBmanager db = new DBmanager();
            db.openConnection();
            Choice choice = null;

            // Execute the SQL Command
            string query = @"SELECT * FROM Choice WHERE Choice_id = " + choiceId;
            SqlCommand command = new SqlCommand(query, db.conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                choice = new Choice();
                choice.choice_id = (int)reader["Choice_id"];
                choice.question_order = (int)reader["Question_order"];
            }

            db.closeConnection();
            return choice;
        }




        //Retrieve the choices from DB by questionId
        public static List<Choice> GetChoices(int questionId)
        {
            //Connect to DB
            DBmanager db = new DBmanager();
            db.conn.Open();

           
            List<Choice> choices = new List<Choice>();

            // Execute the SQL Command
            string query = "SELECT * FROM Choice WHERE Question_id = @Question_id";
            SqlCommand command = new SqlCommand(query, db.conn);
            command.Parameters.AddWithValue("@Question_Id", questionId);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var choice = new Choice();
                choice.choice_id = (int)reader["Choice_id"];
                choice.choice_text = reader["Choice_text"].ToString();
                choice.max_choice = (int)reader["Max_choice"];
                choice.q_id = (int)reader["Question_id"];
                choice.question_order = (int)reader["Question_order"];
                choices.Add(choice);
            }
            db.closeConnection();
            return choices;
        }

        //Manage question order by choiceId to be able to be assign right next question 
        /*
        public static Choice createSkipChoice(string cho_txt,int question_id)
        {
            DBmanager db = new DBmanager();
            db.openConnection();
            Choice choice = null;

            // Execute the SQL Command
            string query = @"INSERT INTO Choice (Choice_text,Question_id) VALUES (@cho_text,@question_id)";
            SqlCommand command = new SqlCommand(query, db.conn);
            command.Parameters.AddWithValue("@cho_text", cho_txt);
            command.Parameters.AddWithValue("@question_id", question_id);
            //  sqlCommand.Parameters.AddWithValue("@respondent_id", answer.respondent_id);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                choice = new Choice();
                choice.choice_id = (int)reader["Choice_id"];
                choice.question_order = (int)reader["Question_order"];
            }

            db.closeConnection();
            return choice;
        }*/
    }
}
