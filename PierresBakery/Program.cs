using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Pierres Bakery!");
      Console.WriteLine("A single loaf of bread costs $5, and every third loaf is free.");
      Console.WriteLine("How many loaves of bread would you like to buy?");
      string breadOrderString = Console.ReadLine();  
      Console.WriteLine("A single pastry costs $2, and every fourth pastry is free.");
      Console.WriteLine("How many pastries would you like to buy?");
      string pastryOrderString = Console.ReadLine();
      int breadOrderInt = int.Parse(breadOrderString);
      int pastryOrderInt = int.Parse(pastryOrderString);
      Bread breadOrder = new Bread(breadOrderInt);
      Pastry pastryOrder = new Pastry(pastryOrderInt);
      ConfirmOrEditOrder(breadOrder, pastryOrder);
    }

    static void ConfirmOrEditOrder(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine("Please confirm that your order:");
      Console.WriteLine($"{breadOrder.Loaves}");
      Console.WriteLine($"{pastryOrder.Pastries}");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to reorder");
      string userInput = Console.ReadLine();  
      if (userInput == "yes")
      {

        CalculateTotalPrice(breadOrder, pastryOrder);
        
      }
      else
      {
        Console.WriteLine("Let's fix your order. Please enter your order again");
        Console.WriteLine("Please enter your bread order:");
        string breadOrderString = Console.ReadLine();  
        Console.WriteLine("Please enter your pastry order:");
        string pastryOrderString = Console.ReadLine();  
        breadOrder.Loaves = int.Parse(breadOrderString);  
        pastryOrder.Pastries = int.Parse(pastryOrderString);  
        ConfirmOrEditOrder(breadOrder, pastryOrder);
      }
    }

    static void CalculateTotalPrice(Bread breadOrder, Pastry pastryOrder)
    {
      int result1 = breadOrder.CalculateBreadTotalPrice();
      int result2 = pastryOrder.CalculatePastryTotalPrice();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + "$" + (result1 + result2) + ".");
      Console.WriteLine("-----------------------------------------");
    }
  }
}
