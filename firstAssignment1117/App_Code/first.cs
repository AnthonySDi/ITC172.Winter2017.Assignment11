using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for first
/// </summary>
public class first
{
    /// <summary>
    /// Fields are class level variables. They basically describe the class
    /// </summary>
    public double MealAmount { set; get; }
    public double TipPercent { set; get; }

    private const double TAXPERCENT = .09;
    public first()
    {
        //
        // TODO: Constructors initialize the class. 
        //

        MealAmount = 0;
        TipPercent = 0;
    }

    public first(double meal, double percent)
    {
        MealAmount = meal;
        TipPercent = percent;
       
    }

    public double CalculateTax()
    {
        return MealAmount * TAXPERCENT;
    }

    public double CalculateTip()
    {
        return MealAmount * TipPercent;
    }

    public double CalculateTotal()
    {
        return MealAmount + CalculateTax() + CalculateTip();
    }
}