using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Survey_app.Model.DAO
{
    public class RespondentDAO
    {


        public static int InsertMember(List<Member> member)
        {
            try
            {
                DBmanager db = new DBmanager();
                db.openConnection();
                int memberId = -1;

               foreach(Member member1 in member)
                {
                    String query =@"INSERT INTO Member (Given_name, Last_name, DOB, Phone_num)
                                                         VALUES (@givenName, @lastName, @DOB, @phoneNum);
                                                        SELECT SCOPE_IDENTITY()";
                    SqlCommand command = new SqlCommand(query, db.conn);
                    command.Parameters.AddWithValue("@givenName", member1.givenName);
                    command.Parameters.AddWithValue("@lastName", member1.lastName);
                    command.Parameters.AddWithValue("@DOB", member1.DOB);
                    command.Parameters.AddWithValue("@phoneNum ", member1.phoneNumber);
                    memberId = Convert.ToInt32(command.ExecuteScalar());
                }

                db.closeConnection();
                return memberId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int InsertRespondent(List<Respondent> respondents,int memberId)
        {
            try
            {
                DBmanager db = new DBmanager();
                db.openConnection();
                int respondentId = -1;

                foreach (Respondent respondent in respondents)
                {

                    String query = @"INSERT INTO Respondent (Email, IP_address, Date, Member_id)
                                                              VALUES (@res_email, @res_Ip, @res_DataStamp, @Member_id);
                     SELECT SCOPE_IDENTITY()";
                    SqlCommand command = new SqlCommand(query, db.conn);
                    command.Parameters.AddWithValue("@res_email", respondent.res_email);
                    command.Parameters.AddWithValue("@res_Ip", respondent.res_Ip);
                    command.Parameters.AddWithValue("@res_DataStamp", respondent.res_DateStamp);
                    command.Parameters.AddWithValue("@Member_id", memberId);
                   // command.ExecuteNonQuery();
                    respondentId = Convert.ToInt32(command.ExecuteScalar());
                }

                db.closeConnection();
                  return respondentId;
            }
            catch (Exception)
            {
                throw;
            }
        }




        public static Respondent getRespondentId(string res_Ip)
        {
            //Connect to DB
            DBmanager db = new DBmanager();
            db.conn.Open();

            Respondent respondent = null;

            string query = "SELECT * FROM Member WHERE IP_address = @res_Ip";
            SqlCommand command = new SqlCommand(query, db.conn);
            command.Parameters.AddWithValue("@res_Ip", res_Ip);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                respondent = new Respondent();
                respondent.res_id = (int)reader["Respondent_id"];

            }
            db.closeConnection();
            return respondent;

        }



        public static string GetIPAddress()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }
            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
        /*
        public static List<Respondent> GetAllRespondents()
        {
            //Connect to DB
            DBmanager db = new DBmanager();
            db.conn.Open();


            List<Respondent> respondents = new List<Respondent>();

            // Execute the SQL Command
            string query = "SELECT * FROM Respondent";
            SqlCommand command = new SqlCommand(query, db.conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var respondent = new Respondent();
                respondent.choice_id = (int)reader["Choice_id"];
                choice.choice_text = reader["Choice_text"].ToString();
                choice.max_choice = (int)reader["Max_choice"];
                choice.q_id = (int)reader["Question_id"];
                choice.question_order = (int)reader["Question_order"];
                choices.Add(choice);
            }
            db.closeConnection();
            return choices;
        }
        */
    }
}