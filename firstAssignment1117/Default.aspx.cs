using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] tipPercent = { "Ten Percent", "Fifteen Percent", "Twenty Percent", "Other" };
            TipPercentsRBL.DataSource = tipPercent;
            TipPercentsRBL.DataBind();
        }
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        GetInfo();
    }

    protected void GetInfo()
    {
        first tip = new first();
        tip.MealAmount = double.Parse(MealTextBox.Text);
         
        if(OtherTextBox.Text=="")
        {
            tip.TipPercent = 0;
            foreach (ListItem item in TipPercentsRBL.Items)
            {
                
                if (item.Text.Equals("Ten Percent"))
                {
                    tip.TipPercent = .1;
                }
                    else if (item.Text.Equals("Fifteen Percent"))
                {
                    tip.TipPercent = .15;
                }
                    else if (item.Text.Equals("Twenty Percent"))
                {
                    tip.TipPercent = .2;
                }
          
          } // end foreach
        }// end if
        else
        {
            tip.TipPercent = double.Parse(OtherTextBox.Text);
        }

        Result.Text = "Amount: " + tip.MealAmount.ToString() + "<br />" + 
            "Tip: " + tip.CalculateTip().ToString() +"<br/>" +
            "Tax: " + tip.CalculateTax().ToString()+ "<br/>"+
            "Total: " + tip.CalculateTotal().ToString();
    } // end getinfo





}