using System;

public class Program
{
    static void Main(string[] args)
    {
        // The prices of items
        System.Console.WriteLine("----------Ruben's Supermarket----------");
        System.Console.WriteLine("Old Man Medicine(M).............$177.03");
        System.Console.WriteLine("Redbull(R).......................$42.00");
        System.Console.WriteLine("Guns(G)..........................$69.42");
        System.Console.WriteLine("Walking Stick(S).................$80.08");

        double Mmenu = 177.03;
        double Hmenu = 42.00;
        double Gmenu = 69.42;
        double Smenu = 80.08;

        Console.Write("Enter which items you would like to buy(M/R/G/S): ");
        char menuc = Console.ReadLine().ToUpper()[0]; // Capitalizes the input

        Console.Write("Enter amount of items for purchase: ");
        double menua = Convert.ToDouble(Console.ReadLine());

        double subtotal = 0;
        if (menuc == 'M') 
        {
            subtotal = menua * Mmenu;
        }
        else if (menuc == 'R')
        {
            subtotal = menua * Hmenu;
        }
        else if (menuc == 'G')
        {
            subtotal = menua * Gmenu;
        }
            else if (menuc == 'S')
        {
            subtotal = menua * Smenu;
        }
        else
        {
            Console.Write("You have imputed an invaild option");
        }

        double tax = subtotal * 0.0725;
        double Finaltotal = tax + subtotal;

        System.Console.WriteLine("Subtotal: " + subtotal);
        System.Console.WriteLine("Sales Tax: " + tax);
        System.Console.WriteLine("Final total: " + Finaltotal);
    }
}
