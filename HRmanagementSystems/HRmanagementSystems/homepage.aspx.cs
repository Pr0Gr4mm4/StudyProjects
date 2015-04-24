using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRmanagementSystems
{
    public partial class homepage : System.Web.UI.Page
    {
        internal static UserInfo objUserInfo { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userInfo"] != null)
            {
                objUserInfo = (UserInfo)Session["userInfo"];
                ((Label)Master.FindControl("lblEmployeeName")).Text = string.Format("{0} {1}",objUserInfo.FirstName,objUserInfo.LastName);
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        public static int GetEmployeeDepartmentID
        {
            get
            {
                return objUserInfo.DepartmentID;
            }
        }
    }
}