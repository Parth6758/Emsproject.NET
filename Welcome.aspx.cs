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
    public partial class Welcome : System.Web.UI.Page
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
        public static string eml=string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["s_eml"] != null)
            {
                eml = Session["s_eml"].ToString();
                Label1.Text = eml;
                fnFetchUserDetails();
            }
            else
            {
                Response.Write("~/Login.aspx");
            }
        }
        public void fnFetchUserDetails()
        {
            fnConnection();
            String qry = "select * from tblCustomer where Email = @u_eml";
            cmd = new SqlCommand(qry,conn);
            cmd.Parameters.AddWithValue("@u_eml", eml);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                lblname.Text = dr["Name"].ToString();
                Lblphone.Text = dr["Phone"].ToString();
                lbladd.Text = dr["Address"].ToString();
                
            }
            dr.Close();
        }
    }

    
}