using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emsproject
{
    public partial class Welcome : System.Web.UI.Page
    {
        public static string eml=string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["s_eml"] != null)
            {
                eml = Session["s_eml"].ToString();
                Label1.Text = eml;
            }
            else
            {
                Response.Write("~/Login.aspx");
            }
        }
    }
}