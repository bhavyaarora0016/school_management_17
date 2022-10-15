using bal;
using dataaccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace school_management
{
    public partial class showsubjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          details_school b = new details_school();
            List<subject> products = new List<subject>();
            products = b.GetProducts1();

            GridView1.DataSource = products;
            GridView1.DataBind();

        }
    }
}