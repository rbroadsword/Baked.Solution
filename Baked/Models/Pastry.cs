using System.Collections.Generic; 
using System;

namespace Baked.Models
{
  public class PastryOrder
  {
    public int NumberOfPastry { get; set; }

    public PastryOrder(int numberOfPastry)
    {
      NumberOfPastry = numberOfPastry; 
    }

    public int PastryCost(int numberOfPastry)
    {
      int pastryTotal = 0; 
      if (numberOfPastry >= 6)
      {
        int bySix = numberOfPastry/6; 
        int sixRemainder = numberOfPastry % 6; 
        pastryTotal = (bySix * 10) + ((sixRemainder * 2));  

      }  else if (numberOfPastry >= 3 && numberOfPastry < 6) 
      {
        pastryTotal = numberOfPastry * 2 -1;
      } else 
      {
        pastryTotal = numberOfPastry *2; 
      }
      return pastryTotal; 
    }
  }
}