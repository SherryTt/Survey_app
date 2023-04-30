﻿using System;
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
        bool empty = true;
        bool nameSearch = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if is loading for the first time
            if (!IsPostBack)
            {
                BindGrid();
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
                    sqlStatement = "SELECT * FROM Member";
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

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            DBmanager db = new DBmanager();
            db.openConnection();

            int count = -1;

            StringBuilder searchQuery = new StringBuilder("SELECT r.Respondent_id,m.Given_name,m.Last_name FROM Answer a JOIN Respondent r ON a.respondent_id = r.Respondent_id JOIN Member m ON r.Member_id = m.Member_id WHERE a.Answer_text In (");

         
                //Search in a.Answer_text
                if (RadioButton1.Checked)
                {
                    empty = false;
                    searchQuery.Append("'" + RadioButton1.Text + "',");
                }
                else if (RadioButton2.Checked)
                {
                    empty = false;
                    searchQuery.Append("'" + RadioButton2.Text + "',");
                }
                if (Regex.IsMatch(AgeDropDownList.SelectedItem.Value, @"^\d+$"))
                {
                    empty = false;
                    searchQuery.Append("'" + AgeDropDownList.SelectedItem.Text + "',");
                }
                if (Regex.IsMatch(StateDropDownList.SelectedItem.Value, @"^\d+$"))
                {
                    empty = false;
                    searchQuery.Append("'" + StateDropDownList.SelectedItem.Text + "',");
                }
                if (Regex.IsMatch(BankDropDownList.SelectedItem.Value, @"^\d+$"))
                {
                    empty = false;
                    searchQuery.Append("'" + BankDropDownList.SelectedItem.Text + "',");
                }

                if (Regex.IsMatch(ServiceDropDownList.SelectedItem.Value, @"^\d+$"))
                {
                    empty = false;
                    searchQuery.Append("'" + ServiceDropDownList.SelectedItem.Text + "',");
                }

                if (Regex.IsMatch(NewsPDropDownList.SelectedItem.Value, @"^\d+$"))
                {
                    empty = false;
                    searchQuery.Append("'" + NewsPDropDownList.SelectedItem.Text + "',");
                }

                //If a.Answer_text is null and search only text box input(Given/Last name)
                //Query will be modified for only searching Memeber table
            if (empty == true)
            {
                nameSearch = true;
                if (!string.IsNullOrEmpty(firstnameTxtBox.Text))
                {
                    searchQuery.Length = searchQuery.Length - 18;
                    searchQuery.Append(" m.Given_name Like '" + firstnameTxtBox.Text.Trim() + "' AND ");
                }
                if (!string.IsNullOrEmpty(lastnameTxtBox.Text))
                {
                    count = count + 1;
                    searchQuery.Append("m.Last_name Like '" + lastnameTxtBox.Text.Trim() + "' AND ");
                }

            }
            //If a.Answer_text and name is searched
            else if (empty == false) {
                nameSearch = true;
                //Delete last "," for dropbox query
                searchQuery.Length = searchQuery.Length - 1;
                if (!string.IsNullOrEmpty(firstnameTxtBox.Text))
                {
                    searchQuery.Append(") AND m.Given_name Like '" + firstnameTxtBox.Text.Trim() + "' AND ");

                    if (!string.IsNullOrEmpty(lastnameTxtBox.Text))
                    {
                        searchQuery.Append("m.Last_name Like '" + lastnameTxtBox.Text.Trim() + "' AND ");
                    }
                }
                else if(string.IsNullOrEmpty(firstnameTxtBox.Text))
                    if (!string.IsNullOrEmpty(lastnameTxtBox.Text))
                    {
                        searchQuery.Append(") AND m.Last_name Like '" + lastnameTxtBox.Text.Trim() + "' AND ");
                    }
                }

            //Delete last 5char " AND " when given or last name search
            if (nameSearch == true)
            {
                searchQuery.Length = searchQuery.Length - 5;
            }


                //If staff search except name, I need close parentheses for a.Answer.text in()
                if ((empty == false)&&(nameSearch == false))
            {
                searchQuery.Append(")");
            }          

            BindGrid(searchQuery.ToString());


        }

    }
}