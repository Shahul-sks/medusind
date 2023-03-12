using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validator
{
    public partial class DropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Listed_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (Listed.SelectedIndex == 0)
            {
                img.ImageUrl = "Pic/laptop.png";
            }
            else if (Listed.SelectedIndex == 1)
            {
                img.ImageUrl = "Pic/mobile.png";
            }
            else if (Listed.SelectedIndex == 2)
            {
                img.ImageUrl = "Pic/headphone.png";
            }          
            else
                img.ImageUrl = "Pic/watch.png";

        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Listed.SelectedIndex > -1)
            {
                int i = Listed.SelectedIndex;
                price.Text = " Selected Item : " + Listed.SelectedItem.Value + " and  Price Rs.  ";
                if (i == 0)
                    price.Text += "65000";
                else if (i == 1)
                    price.Text += "15000";
                else if (i == 2)
                    price.Text += "1500";
                else
                    price.Text += "1200";

            }
        }

    
    }
}