using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleASPnetApp.DataModels;

namespace SampleASPnetApp
{
    public partial class EmployeeRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmployeeData"] != null)
            {
                Employee employee = (Employee)Session["EmployeeData"];

                txtFname.Text = employee.fName;
                txtLname.Text = employee.lName;
                txtAdd1.Text = employee.address;
                txtAdd2.Text = employee.address2;
                txtCity.Text = employee.city;
                txtState.Text = employee.state;
                txtZip.Text = employee.zip.ToString();

                Session["EmployeeData"] = null;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee theEmployee = new Employee();

            theEmployee.fName = txtFname.Text;
            theEmployee.lName = txtLname.Text;
            theEmployee.address = txtAdd1.Text;
            theEmployee.address2 = txtAdd2.Text;
            theEmployee.city = txtCity.Text;
            theEmployee.state = txtState.Text;
            theEmployee.zip = int.Parse(txtZip.Text);

            Session["EmployeeData"] = theEmployee;

            Response.Redirect("EmployeeConfirmation.aspx");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Session["EmployeeData"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}