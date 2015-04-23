using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace HRmanagementSystems
{
    public partial class login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                int rows = (int)sqlComm.ExecuteScalar();

                if(rows == 1)
                {
                    Response.Redirect("homepage.aspx");
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