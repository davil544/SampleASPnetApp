using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleASPnetApp.DataAccessLayer;
using SampleASPnetApp.DataModels;

namespace SampleASPnetApp
{
    public partial class CustomerData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Customer> customerList;
            CustomerTier customerTier = new CustomerTier();
            customerList = customerTier.getAllCustomers();
            grdCustomer.DataSource = customerList;

            grdCustomer.DataBind();
        }
    }
}