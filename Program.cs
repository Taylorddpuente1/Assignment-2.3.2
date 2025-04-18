

// Week 2 Assignment 2.3.2
// Date: Tues, April 15 2025


using System;
class Tipcalculator
{
    static void Main()
    {
        // Ask for the bill total
        Console.WriteLine(" Welcome to the Tip calculator! Please enter the bill total: $ ");
        string billInput = Console.ReadLine();
        double bill = Convert.ToDouble(billInput);

        // Ask for the tip percentage
        Console.WriteLine("Enter the tip percentage(like 15 for 15%):");
        string tipInput = Console.ReadLine();
        double tipPercent = Convert.ToDouble(tipInput) / 100;

        // Calculate tip amount
        double tipAmount = bill * tipPercent;

        //Calculate grand total
        double grandTotal = tipAmount + bill;


        Console.WriteLine();
        Console.WriteLine(" Bill Total : {0:C}", bill);
        Console.WriteLine(" Tip Percentage : {0:P}", tipPercent);
        Console.WriteLine("Tip Amount: {0:C}", tipAmount);
            Console.WriteLine("Grand Total: {0:C}", grandTotal);

    }
}