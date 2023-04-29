using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;
using System.Text;


namespace Survey_app
{
    public partial class AdminSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if is loading for the first time
            if (!IsPostBack)
            {
                
            }
        }


        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session["staff_id"] = null;
            Response.Redirect("../Default.aspx");
        }


     private void BindGrid(string searchQuery = "")
        {
            DBmanager db = new DBmanager();
            DataTable dt = new DataTable();

            //reference from stack overflow
            try
            {
                string sqlStatement;
                db.openConnection();
                if (searchQuery == "")
                    sqlStatement = "SELECT * FROM Respondent";
                else
                    sqlStatement = searchQuery;


                SqlCommand sqlCmd = new SqlCommand(sqlStatement,db.conn);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                sqlDa.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    GridView.DataSource = dt;
                    GridView.DataBind();
                }
                else
                {
                    GridView.DataSource = null;
                    GridView.DataBind();

                    dt.Rows.Add(dt.NewRow());
                    GridView.DataSource = dt;
                    GridView.DataBind();
                    GridView.Rows[0].Visible = false;
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Fetch Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}