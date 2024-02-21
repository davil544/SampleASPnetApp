using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleASPnetApp.DataModels;
using SampleASPnetApp.DataAccessLayer;

namespace SampleASPnetApp
{
    public partial class EmployeeData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> employeeList;
            EmployeeTier employeeTier = new EmployeeTier();
            employeeList = employeeTier.getAllEmployees();
            grdEmployee.DataSource = employeeList;

            grdEmployee.DataBind();
        }
    }
}