using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleASPnetApp.DataModels;

namespace SampleASPnetApp
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerData"] != null)
            {
                Customer customer = (Customer)Session["CustomerData"];

                txtFname.Text = customer.fName;
                txtMname.Text = customer.mName;
                txtLname.Text = customer.lName;
                txtAdd1.Text = customer.address;
                txtAdd2.Text = customer.address2;
                txtCity.Text = customer.city;
                txtState.Text = customer.state;
                txtZip.Text = customer.zip.ToString();

                Session["CustomerData"] = null;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            // divOutput.InnerHtml = "<strong>" + txtFname.Text + " " + txtLname.Text + "</strong>";
            //TODO:  Implement input validation or the form will crash if blank
            Customer theCustomer = new Customer();
            theCustomer.fName = txtFname.Text;
            theCustomer.mName = txtMname.Text;
            theCustomer.lName = txtLname.Text;
            theCustomer.address= txtAdd1.Text;
            theCustomer.address2 = txtAdd2.Text;
            theCustomer.city = txtCity.Text;
            theCustomer.state = txtState.Text;
            theCustomer.zip = int.Parse(txtZip.Text);

            Session["CustomerData"] = theCustomer;

            //Request object used on client, contains query strings.
            //Response objects such as below used on server side.
            Response.Redirect("Confirmation.aspx");
        }
    }
}