using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace HRmanagementSystems
{
    public partial class login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["hrDatabaseConnectionString"].ConnectionString);
            SqlCommand sqlComm = new SqlCommand("spLogin", sqlConn);

            sqlComm.Parameters.Add(new SqlParameter("@loginName", System.Data.SqlDbType.VarChar, 25, "EMAIL") { Value = txtUsername.Text });
            sqlComm.Parameters.Add(new SqlParameter("@password", System.Data.SqlDbType.VarChar, 1000, "PASSWORD") { Value = txtPassword.Text });

            sqlComm.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                sqlConn.Open();
                SqlDataReader sqlReader = sqlComm.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        UserInfo user = new UserInfo((string)sqlReader["FIRST_NAME"], (string)sqlReader["LAST_NAME"], (int)sqlReader["DEPARTMENT_ID"], (DateTime)sqlReader["HIRE_DATE"]);

                        Session.Add("userInfo", user);
                        Response.Redirect("homepage.aspx", false);
                    }
                }
            }
            catch(Exception ex)
            {
                // REPORT ERROR
                
            }
            finally
            {
                sqlConn.Close();
            }


        }
    }
}