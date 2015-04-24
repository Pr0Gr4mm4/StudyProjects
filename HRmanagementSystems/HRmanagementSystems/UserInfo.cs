using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRmanagementSystems
{
    public class UserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentID { get; set; }
        public DateTime HireDate { get; set; }
        public UserInfo() { }
        public UserInfo(string firstName, string lastName, int departmentID, DateTime hireDate)
        {
            FirstName = firstName;
            LastName = lastName;
            DepartmentID = departmentID;
            HireDate = hireDate;
        }
    }
}
