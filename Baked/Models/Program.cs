using System; 
using System.Collections.Generic; 
using Baked.Models; 

namespace Baked {
  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("   Welcome To Pierre's Bakery"); 
      Console.WriteLine("            Menu      "); 
      Console.WriteLine("           Bread:         "); 
      Console.WriteLine("   Single:  $5           "); 
      Console.WriteLine("   Double:  $10          "); 
      Console.WriteLine("   * Buy 2 loaves of bread and receive 1 free");
      Console.WriteLine("           Pastry:         "); 
      Console.WriteLine("   One:      $2"); 
      Console.WriteLine("   Three:    $5"); 
      Console.WriteLine("   Four:     $7"); 
      Console.WriteLine("   Five:     $9"); 
      Console.WriteLine("   Six:      $10"); 
      Console.WriteLine("   Ready to Order? (Y/N)"); 
      string order = Console.ReadLine();
      if (order == "Y" || order == "y")
      {
        Console.WriteLine("   How many loaves of bread would you like?"); 
        string breadOrder = Console.ReadLine(); 
        Console.WriteLine("   How many pastry would you like?"); 
        string pastryOrder = Console.ReadLine(); 
        Console.WriteLine("   You have ordered " + breadOrder + " loaves of bread"); 
        Console.WriteLine("   You have ordered " + pastryOrder + " pastries"); 

      } else 
      {
        Console.WriteLine("See you soon"); 
      }
    }
  }
}