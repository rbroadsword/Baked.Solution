using System.Collections.Generic; 
using System;

namespace Baked.Models
{
  public class BreadOrder
  {
    public int NumberOfBread { get; set; }

    public BreadOrder(int numberOfBread)
    {
      NumberOfBread = numberOfBread; 
    }

    public int BreadCost(int numberOfBread)
    {
      int breadTotal = 0; 
      if (numberOfBread >= 3)
      {
        int bogoBread = numberOfBread/3;
        int remainderBread = numberOfBread % 3; 
        breadTotal += (bogoBread *10) + (remainderBread * 5); 
      } else 
      {
        breadTotal += numberOfBread * 5; 
      }
      return breadTotal; 
    }
  }
}