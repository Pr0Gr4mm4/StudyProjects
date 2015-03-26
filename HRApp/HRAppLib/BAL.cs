using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAppLib
{
    /* This class contains all the LINQ codes needed for the HR Application to work.
     * Definition 'BAL' : Backend Access Layer
     * 
     * Explanation: LINQ is basically SQL code, with a slight difference.
     * LINQ is written as a sort-of reverse SQL.
     * 
     * We use the variable type 'var' because we don't want to assign it a type, 
     * because it already is automatically based on the command.
     * 
     * We use a symbol combination '=>' to define a condition statement, after which the actual condition is given.
     * 
     * In the following example 'A' is actually the OBJECT that is selected by the select command.
     * The given example will select the Employee OBJECT that has an ID equaling 5.
     * 
     * EXAMPLE:
     * var employee = (from employeeObject in dmdContext.EMPLOYEEs select employeeObject).Where(A => A.EMPLOYEE_ID == 5);
     * 
     * Now we have the entire OBJECT / ROW from the database inside the variable employee. We can use this information
     * in gridviews to name an easy example (see the DepartmentLocations.aspx).
     */
    public class BAL
    {
        // We need a context of the database to work with
        HRDataModelDataContext dmdContext = new HRDataModelDataContext();

        /// <summary>
        /// Gets All department names from the HR Database
        /// </summary>
        /// <returns>List of strings containing the Department names</returns>
        public List<string> GetDepartmentNames()
        {
            var departments = (from d in dmdContext.DEPARTMENTs select d.DEPARTMENT_NAME).ToList();
            return departments;
        }

        /// <summary>
        /// Gets all the employees of the given Department
        /// </summary>
        /// <param name="dept">The Department to get the employees from</param>
        /// <returns>List of OBJECT Employee of the given Department</returns>
        public List<EMPLOYEE> GetEmployees(string dept)
        {
            var employees = (from emp in dmdContext.EMPLOYEEs select emp).Where(a => a.DEPARTMENT.DEPARTMENT_NAME == dept).ToList();
            return employees;
        }

        /// <summary>
        /// Gets a specific Employee by filtering on the Employee ID
        /// </summary>
        /// <param name="empID">The ID of the Employee to get</param>
        /// <returns>Single OBJECT Employee that has the given Employee ID</returns>
        public EMPLOYEE GetEmployee(int empID)
        {
            if (empID != null && empID != 0)
            {
                var e = (from emp in dmdContext.EMPLOYEEs select emp).First(a => a.EMPLOYEE_ID == empID);
                return e;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all locations from the HR Database
        /// </summary>
        /// <returns>List of strings containing the Location names</returns>
        public List<string> GetLocations()
        {
            var locations = (from loc in dmdContext.LOCATIONs select loc.CITY).ToList();
            return locations;
        }

        /// <summary>
        /// Gets all departments that are located in the given location
        /// </summary>
        /// <param name="loc">The location to get the departments from</param>
        /// <returns>List of OBJECT Department located at the given location</returns>
        public List<DEPARTMENT> GetDepartments(string loc)
        {
            var departments = (from dep in dmdContext.DEPARTMENTs select dep).Where(a => a.LOCATION.CITY == loc).ToList();
            return departments;
        }

        /// <summary>
        /// Gets the Manager of the given Department
        /// </summary>
        /// <param name="deptID">The Department ID to get the manager from</param>
        /// <returns>Single OBJECT Employee of the manager of the given Department</returns>
        public EMPLOYEE GetDepartmentManager(int deptID)
        {
            if (deptID != 0)
            {
                var manager = (from emp in dmdContext.EMPLOYEEs select emp).First(a => a.DEPARTMENT.MANAGER_ID == a.EMPLOYEE_ID && a.DEPARTMENT_ID == deptID);
                return manager;
            }
            return null;
        }

        public List<getDepartmentsResult> spGetDepartments()
        {
            var depts = dmdContext.getDepartments();
            return depts.ToList();
        }

        public List<getDepartmentEmployeesResult> spGetDepartmentEmployees(int deptID)
        {
            var emps = dmdContext.getDepartmentEmployees(deptID);
            return emps.ToList();
        }

    }
}
