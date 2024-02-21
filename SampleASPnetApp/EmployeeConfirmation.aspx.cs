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
    public partial class EmployeeConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmployeeData"] != null)
            {
                Employee employee = (Employee)Session["EmployeeData"];

                lblFname.Text = employee.fName;
                lblLname.Text = employee.lName;
                lblAdd1.Text = employee.address;
                lblAdd2.Text = employee.address2;
                lblCity.Text = employee.city;
                lblState.Text = employee.state;
                lblZip.Text = employee.zip.ToString();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            EmployeeTier employeeTier = new EmployeeTier();
            Employee employee = (Employee)Session["EmployeeData"];

            employeeTier.insertEmployee(employee);
            Session["EmployeeData"] = null;

            Response.Write("<script>alert('Your form has been submitted!');</script>");

            Response.Redirect("EmployeeData.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}