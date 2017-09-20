using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Primjer_01
{
    public partial class ChooseShipper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoadComplete(EventArgs e)
        {
            base.OnLoadComplete(e);
            if(!IsPostBack)
            {
                RadioButtonList1.SelectedIndex = 0;
            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Thank you " + txtName.Text.Trim() + ". You chose " +
                RadioButtonList1.SelectedItem.Text.ToString() + " whose ID is " +
                RadioButtonList1.SelectedValue.ToString();
        }
    }
}