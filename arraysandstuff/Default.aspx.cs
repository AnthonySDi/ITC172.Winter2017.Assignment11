using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /* 
     * 
     * To Do
     *  - Find way to get Second portion of the array to display
     *  - Add additions onto if statement so it shows.
     * 
     * 
     *  */

    string[,] product = new string[6, 2];

    protected void Page_Load(object sender, EventArgs e)
    {
       // if (!IsPostBack)
        //{

            product[0, 0] = "1/29/2017";
            product[0, 1] = " Starting 10 AM, Join the IXPIQ group for morning meditations";
            product[1, 0] = "1/29/2017";
            product[1, 1] = " Starting 9 PM, Join QIPXI for a smashing good time for their debut heavy metal thing!";
            product[2, 0] = "1/30/2017";
            product[2, 1] = " Starting 8 AM,The XIPL:SF will have an all day seminar of ASP.NET and Database development";
            product[3, 0] = "1/31/2017";
            product[3, 1] = " Starting 9 AM,The SF:LPIX is hosting an PHP and Javascript workshop all day. ";
            product[4, 0] = "2/02/2017";
            product[4, 1] = " Starting 1 PM, How to deal with overly hyped Holidays and the impending breaks they will cause! an intensive all day course on how to prepare for Valintines day.";
            product[5, 0] = "2/14/2017";
            product[5, 1] = " Starting 10 AM, A valentine's day event for those who hate the overly hyped holiday. This year its paintball! What says love like shooting someone with a slug filled with paint?";

            //GetProduce();
       /* }*/ // end of IF
    } // end of Page load

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        product[0, 0] = "1/29/2017";
        product[0, 1] = " Starting 10 AM, Join the IXPIQ group for morning meditations";
        product[1, 0] = "1/29/2017";
        product[1, 1] = " Starting 9 PM, Join QIPXI for a smashing good time for their debut heavy metal thing!";
        product[2, 0] = "1/30/2017";
        product[2, 1] = " Starting 8 AM,The XIPL:SF will have an all day seminar of ASP.NET and Database development";
        product[3, 0] = "1/31/2017";
        product[3, 1] = " Starting 9 AM,The SF:LPIX is hosting an PHP and Javascript workshop all day. ";
        product[4, 0] = "2/02/2017";
        product[4, 1] = " Starting 1 PM, How to deal with overly hyped Holidays and the impending breaks they will cause! an intensive all day course on how to prepare for Valintines day.";
        product[5, 0] = "2/14/2017";
        product[5, 1] = " Starting 10 AM, A valentine's day event for those who hate the overly hyped holiday. This year its paintball! What says love like shooting someone with a slug filled with paint?";

        //string Birthday = "5/9/2017";
        //DateTime birthday = Convert.ToDateTime(product[0, 0]);
        //DateTime birthday = DateTime.Parse("5/9/2017");
        for (int i = 0; i < 6; i++)
        {
            Label1.Text = Calendar1.SelectedDate.ToShortDateString();
            if (product[i, 0] == Calendar1.SelectedDate.ToShortDateString())
            {
                Label1.Text += product[i, 1];
            }
        }
        //if (Calendar1.SelectedDate==Convert.ToDateTime(product[0, 0]))
        //    // string birthday = "5/9/2017";

        //    Label1.Text += product[0, 1];
        //}
    } // end Calendar_SelectionChanged

    protected void Calendar1_DayRender(object sender,
    DayRenderEventArgs e)
    {
        // Display vacation dates in yellow boxes with purple borders.
        Style vacationStyle = new Style();
        vacationStyle.BackColor = System.Drawing.Color.Yellow;
        vacationStyle.BorderColor = System.Drawing.Color.Purple;
        vacationStyle.BorderWidth = 3;

        // Display weekend dates in green boxes.
        Style weekendStyle = new Style();
        weekendStyle.BackColor = System.Drawing.Color.Green;
        for (int i = 0; i < 6; i++)
        {
            if (e.Day.Date == DateTime.Parse(product[i, 0]))
            {
                // Apply the vacation style to the vacation dates.
                e.Cell.ApplyStyle(vacationStyle);
            }
            else if (e.Day.IsWeekend)
            {
                // Apply the weekend style to the weekend dates.
                e.Cell.ApplyStyle(weekendStyle);
            }
        }
    }   




        //    protected void GetProduce()
        //    {
        //    for (int i = 0; i < 6; i++)
        //    {
        //        ListItem item = new ListItem();
        //        item.Text = product[i, 0];

        //    }
        //} // End Method GetProduce()

    } // end partial class


