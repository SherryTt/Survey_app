using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey_app.Model.DAO;
using Survey_app.Model;


namespace Survey_app.Staff
{
    
    public partial class StaffLogin : System.Web.UI.Page
    {
        StaffDAO staffDAO = new StaffDAO();
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String username = userIdTextBox.Text.Trim();
            String passward = userPassTextBox.Text.Trim();
           
            var loginSuccess = Login(username,passward);
            if (loginSuccess)
                Response.Redirect("StaffSearch.aspx");
            else
                errorLabel.Text = "Incorrect username or password";

           
        }

        public bool Login(string username, string password)
        {
            var staff = staffDAO.StaffLoginbyIdandPass(username, password);
            if (staff != null)
            {
                HttpContext.Current.Session["staff_id"] = staff.Id;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

