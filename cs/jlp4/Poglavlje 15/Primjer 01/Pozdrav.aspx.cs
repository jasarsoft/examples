using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Primjer_01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrikaz_Click(object sender, EventArgs e)
        {
            lblPozdrav.Text = txtIme.Text + ", dobro došli u ASP.NET";
        }
    }
}