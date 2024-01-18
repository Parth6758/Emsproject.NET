using System;
using System.Collections.Generic;
using System.Configuration;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emsproject
{
    public partial class ems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                fnBindtype();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            String type = ddltype.Text;
            String brand = ddlbrand.Text;
            String model = txtmodel.Text;
            String desc = txtdesc.Text;
            String quantity = txtquantity.Text;
            String color = rblcolor.Text;

            String resultText = "Type: " + type + "</br>" + 
            "Brand: " + brand + "</br>" +
            "Model: " + model + "</br>" +
            "desc: " + desc + "</br>" +
            "quantity: " + quantity + "</br>" +
            "color: " + color;



            Label1.Text = resultText;
        }

        protected void ddltype_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            fnBindbrand();
        }
        protected void fnBindtype()
        {
            ddltype.Items.Add("Mobile");
            ddltype.Items.Add("Laptop");
            ddltype.Items.Add("Tablet"); 
            ddltype.Items.Insert(0, new ListItem("Select Type"));
        }

        protected void fnBindbrand()
        {
            ddlbrand.Items.Clear();
            if (ddltype.SelectedValue == "Mobile")
            {
              
                ddlbrand.Items.Add("Samsung");
                ddlbrand.Items.Add("Apple");
            }

            if (ddltype.SelectedValue == "Laptop")
            {
                
                ddlbrand.Items.Add("HP");
                ddlbrand.Items.Add("DELL");
            }

            if (ddltype.SelectedValue == "Tablet")
            {
             
                ddlbrand.Items.Add("Asus");
                ddlbrand.Items.Add("Redmi");
            }

            //ddlbrand.Items.Insert(0, new ListItem("Select brand"));
        }
    }
}