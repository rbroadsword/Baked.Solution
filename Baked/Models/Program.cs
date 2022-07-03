using System; 
using System.Collections.Generic; 
using Baked.Models; 

namespace Baked {
  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("  Kornbread the Snack's Shack "); 
      Console.WriteLine("            Menu      "); 
      Console.WriteLine("          --------      "); 
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
        string stringBreadOrder = Console.ReadLine();
        int intBreadOrder = int.Parse(stringBreadOrder); 
        Console.WriteLine("   How many pastry would you like?"); 
        string stringPastryOrder = Console.ReadLine();
        int intPastryOrder = int.Parse(stringPastryOrder); 
        Console.WriteLine("   Your order: "); 
        Console.WriteLine(intBreadOrder + " Steaming, piping fresh hot bread loaves!"); 
        Console.WriteLine(intPastryOrder + " Oooey goooey delectible pastry"); 
        PastryOrder currentPastryOrder = new PastryOrder(intPastryOrder); 
        BreadOrder currentBreadOrder = new BreadOrder(intBreadOrder); 
        Console.WriteLine("  Your order total is: " + (currentPastryOrder.PastryCost(intPastryOrder) + currentBreadOrder.BreadCost(intBreadOrder))); 

      } else 
      {
        Console.WriteLine("Heeney this ain't no Olive Garden, purchase some bread or move along."); 
      }
    }
  }
}