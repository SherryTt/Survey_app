using System;
using System.Data.SqlClient;

namespace Survey_app.Model.DAO
{
    public class StaffDAO
    {

        public Staff StaffLoginbyIdandPass(string username, string password)
        {

            DBmanager db = new DBmanager();
            db.openConnection();
            Staff staff = null;
            string query = @"SELECT * FROM Staff WHERE User_name = @username AND Password = @password";
            SqlCommand command = new SqlCommand(query, db.conn);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                staff = new Staff();
                staff.Id = (int)reader["staff_id"];
            }
            db.closeConnection();
            return staff;
        }
    }
}