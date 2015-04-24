using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace HRmanagementSystems
{
    public partial class ucDepartmentEmployees : System.Web.UI.UserControl
    {
        private static DataTable dtDepartmentEmployees;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["hrDatabaseConnectionString"].ConnectionString);
                SqlCommand sqlComm = new SqlCommand("spDepartmentEmployees", sqlConn);
                sqlComm.Parameters.Add(new SqlParameter("@DepartmentID", System.Data.SqlDbType.Int, 10, "DEPARTMENT_ID") { Value = homepage.objUserInfo.DepartmentID });
                sqlComm.Parameters.Add(new SqlParameter("@ManagerFirstName", System.Data.SqlDbType.VarChar, 20, "FIRST_NAME") { Value = homepage.objUserInfo.FirstName });
                sqlComm.Parameters.Add(new SqlParameter("@ManagerLastName", System.Data.SqlDbType.VarChar, 25, "LAST_NAME") { Value = homepage.objUserInfo.LastName });
                sqlComm.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    sqlConn.Open();
                    SqlDataReader sqlReader = sqlComm.ExecuteReader();
                    dtDepartmentEmployees = new DataTable();
                    dtDepartmentEmployees.Load(sqlReader);
                }
                catch
                {
                    // Report ERROR
                }
                finally
                {
                    sqlConn.Close();
                }
                foreach(DataRow dr in dtDepartmentEmployees.Rows)
                {
                    ListItem li = new ListItem(string.Format("{0} {1}",(string)dr["FIRST_NAME"],(string)dr["LAST_NAME"]),dr["EMPLOYEE_ID"].ToString());
                    ddlDepartmentEmployees.Items.Add(li);
                }
                dtDepartmentEmployees.PrimaryKey = new DataColumn[] { dtDepartmentEmployees.Columns["EMPLOYEE_ID"] };
            }
            EditDetailsView();
        }

        protected void ddlDepartmentEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EditDetailsView()
        {
            int employeeID = int.Parse(ddlDepartmentEmployees.SelectedItem.Value);
            dvDepartmentEmployee.DataSource = dtDepartmentEmployees;
            dtDepartmentEmployees.DefaultView.RowFilter = "EMPLOYEE_ID=" + employeeID;
            dvDepartmentEmployee.DataBind();
        }

    }
}