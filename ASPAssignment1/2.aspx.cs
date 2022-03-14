using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPAssignment1
{
    public partial class _2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = Hero.SelectedValue;
            Image1.ImageUrl = str + ".jpg";
            if(Hero.SelectedValue == "Hero")
            {
                Label1.Text = "Price Of Vehicle";
            }
            if (Hero.SelectedValue=="Glamour")
            {
               
                Label1.Text = "110000";
            }
            if (Hero.SelectedValue == "Splender")
            {
                
                Label1.Text = "86000";
            }
            if (Hero.SelectedValue == "Pleasure")
            {
               
                Label1.Text = "80000";
            }
            if (Hero.SelectedValue == "Passion")
            {
                
                Label1.Text = "95000";
            }
            if (Hero.SelectedValue == "Hero Ismart")
            {
               
                Label1.Text = "98000";
            }
        }
    }
}