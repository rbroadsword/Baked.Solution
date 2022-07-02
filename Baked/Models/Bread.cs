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
      if (numberOfBread % 3 == 0 || numberOfBread % 2 == 0)
      {
        breadTotal =  10; 
      } else if (numberOfBread == 1)
      {
        breadTotal += 5;
      }
      return breadTotal; 
    }
  }
}