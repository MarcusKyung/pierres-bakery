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
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Prices:");
      Console.WriteLine("Bread --- $5/loaf --- A single loaf of bread costs $5, and every third loaf is free.");
      Console.WriteLine("Pasteries --- $2/pastry --- A single pastry costs $2, and every fourth pastry is free.");
      Console.WriteLine("How many loaves of bread would you like to buy?");
      string breadOrderString = Console.ReadLine();  
      Console.WriteLine("How many pastries would you like to buy?");
      string pastryOrderString = Console.ReadLine();
      try
      {
        int breadOrderInt = int.Parse(breadOrderString);
        int pastryOrderInt = int.Parse(pastryOrderString);
        Bread breadOrder = new Bread(breadOrderInt);
        Pastry pastryOrder = new Pastry(pastryOrderInt);
        ConfirmOrEditOrder(breadOrder, pastryOrder);
      }
      catch (Exception)
      {
        Console.WriteLine("That wasn't a number! Please try again.");
        Main();
      }
    }

    static void ConfirmOrEditOrder(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine("Please confirm that your order:");
      if ($"{breadOrder.Loaves}" == "1" && $"{pastryOrder.Pastries}" == "1")
      {
        Console.WriteLine($"You want {breadOrder.Loaves} loaf of bread and {pastryOrder.Pastries} pastry?");
      }
      else if ($"{breadOrder.Loaves}" != "1" && $"{pastryOrder.Pastries}" == "1")
      {
        Console.WriteLine($"You want {breadOrder.Loaves} loaves of bread and {pastryOrder.Pastries} pastry?");
      }
      else if ($"{breadOrder.Loaves}" == "1" && $"{pastryOrder.Pastries}" != "1")
      {
        Console.WriteLine($"You want {breadOrder.Loaves} loaf of bread and {pastryOrder.Pastries} pastries?");
      } 
      else
      {
        Console.WriteLine($"You want {breadOrder.Loaves} loaves of bread and {pastryOrder.Pastries} pastries?");
      } 
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to reorder");
      string userInput = Console.ReadLine();  
      if (userInput == "yes" || userInput == "YES" || userInput == "Yes")
      {
        CalculateTotalPrice(breadOrder, pastryOrder);
      }
      else
      {
        Console.WriteLine("Let's fix your order. Please enter your order again");
        Console.WriteLine("How many loaves of bread would you like?");
        string breadOrderString = Console.ReadLine();  
        Console.WriteLine("How many pasteries would you like?");
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
      if ($"{breadOrder.Loaves}" == "1" && $"{pastryOrder.Pastries}" == "1")
      {
        Console.WriteLine($"Your total cost for {breadOrder.Loaves} loaf of bread and {pastryOrder.Pastries} pastry is " + "$" + (result1 + result2) + ".");
      }
      else if ($"{breadOrder.Loaves}" != "1" && $"{pastryOrder.Pastries}" == "1")
      {
        Console.WriteLine($"Your total cost for {breadOrder.Loaves} loaves of bread and {pastryOrder.Pastries} pastry is " + "$" + (result1 + result2) + ".");
      }
      else if ($"{breadOrder.Loaves}" == "1" && $"{pastryOrder.Pastries}" != "1")
      {
        Console.WriteLine($"Your total cost for {breadOrder.Loaves} loaf of bread and {pastryOrder.Pastries} pastries is " + "$" + (result1 + result2) + ".");
      } 
      else
      {
        Console.WriteLine($"Your total cost for {breadOrder.Loaves} loaves of bread and {pastryOrder.Pastries} pastries is " + "$" + (result1 + result2) + ".");
      }
      Console.WriteLine("Thanks for your order!"); 
      Console.WriteLine("-----------------------------------------");
    }
  }
}
