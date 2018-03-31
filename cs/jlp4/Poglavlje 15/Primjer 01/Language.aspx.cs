using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Primjer_01
{
    public partial class Language : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrijava_Click(object sender, EventArgs e)
        {
            //IsValid svojstvo ima  vrijednost True ukoliko je valdacija cijele
            //strane na serveru bila uspjesna i obrnuto
            if(Page.IsValid)
            {
                lblPoruka.Text = "Hvala sto ste se prijavili";
                //kod realni aplikacija ovdje se obicno podaci uneseni na formi ili ubacuju u bazu ili porede sa podacima iz baze
            }
        }
    }
}