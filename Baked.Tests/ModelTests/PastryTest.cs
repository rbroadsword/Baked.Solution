using Microsoft.VisualStudio.TestTools.UnitTesting;
using Baked.Models; 

namespace Baked.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryConstructor_CreatePastryOrder_PastryOrder()
    {
      PastryOrder myPastryOrder = new PastryOrder(2); 
      Assert.AreEqual(typeof(PastryOrder), myPastryOrder.GetType()); 
    }

    [TestMethod]
    public void PastryCost_FindPastryOrderTotal_2()
      {
        PastryOrder myPastryOrder = new PastryOrder(1); 
        Assert.AreEqual(2, myPastryOrder.PastryCost(1)); 
      }

    [TestMethod]
    public void PastryCost_IncorporateDeal_5()
    {
      PastryOrder myPastryOrder = new PastryOrder(3);
      Assert.AreEqual(5, myPastryOrder.PastryCost(3));
    }
  }
}