using System;
using System.Collections.Generic;
using System.Configuration;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Services.Description;

namespace Emsproject
{
    public partial class ems : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        public void fnConnection()
        {

            try
            {
                String constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                conn = new SqlConnection(constr);
                if (conn.State != ConnectionState.Open)
                
                    conn.Open();
                
               // Response.Write("Database Connected Succesfully");


            }
            catch (Exception e)
            {
                Response.Write(e.ToString());
            }
        }

        public void fnBindBrand()
        {
            try
            {
                fnConnection();
                String qry = "select d.b_id, b.BrandName, d.model, d.description, d.Price, d.quantity from tblDevice d, tblBrand b WHERE d.b_id = b.b_id";
                cmd = new SqlCommand(qry,conn);
                sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();
                conn.Close();   
            }
            catch (Exception)
            {

                throw;
            }
        }
        
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                fnBindtype();
                fnConnection();
            }
            fnBindBrand();



        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            String type = ddltype.Text;
            String brand = ddlbrand.Text;
            String model = txtmodel.Text;
            String desc = txtdesc.Text;
            String quantity = txtquantity.Text;
            String color = rblcolor.Text;
            String Ass = cblass.Text;

            String resultText = "Type: " + type + "</br>" +
            "Brand: " + brand + "</br>" +
            "Model: " + model + "</br>" +
            "desc: " + desc + "</br>" +
            "quantity: " + quantity + "</br>" +
            "color: " + color + "</br>" +
            "Assesories: " + Ass + "</br>";






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

        protected void Reset_Click(object sender, EventArgs e)
        {
            ddltype.SelectedIndex = -1;
            ddlbrand.SelectedIndex = -1;
            txtmodel.Text = String.Empty;
            txtdesc.Text = String.Empty;
            txtquantity.Text = String.Empty;
            rblcolor.ClearSelection();
            cblass.ClearSelection();




        }
    }
}
