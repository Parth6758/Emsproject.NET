using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Emsproject
{
    public partial class Login : System.Web.UI.Page
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                fnConnection();
            }
        }

          protected void Password_TextChanged(object sender, EventArgs e)
        {
            // Your Password_TextChanged logic here
        }

        protected void login1_Click(object sender, EventArgs e)
        {
            try
            {
                fnConnection();
                String qry = "select count(*) from tblCustomer where Email=@eml and Password=@pwd";
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("eml", Email.Text);
                cmd.Parameters.AddWithValue("pwd", Passsword.Text);
                int cnt = (int)cmd.ExecuteScalar();
                if (cnt > 0)
                {
                    Session["s_eml"] = Email.Text;
                    Response.Redirect("~/Welcome.aspx");
                }
                else
                {
                    Response.Write("Incorrect email or password");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                Response.Write(ex.ToString());
            }
        }
    }
}