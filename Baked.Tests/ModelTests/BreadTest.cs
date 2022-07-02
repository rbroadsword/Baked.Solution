using Microsoft.VisualStudio.TestTools.UnitTesting;
using Baked.Models; 

namespace Baked.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadConstructor_CreateBreadOrder_BreadOrder()
    {
      BreadOrder myBreadOrder = new BreadOrder(2); 
      Assert.AreEqual(typeof(BreadOrder), myBreadOrder.GetType()); 
    }
    
    [TestMethod]
    public void BreadCost_FindBreadOrderTotal_5()
    {
      BreadOrder myBreadOrder = new BreadOrder(1); 
      Assert.AreEqual(5, myBreadOrder.BreadCost(1)); 
    }

    [TestMethod]
    public void BreadCost_IncorporateDeal_10()
    {
      BreadOrder myBreadOrder = new BreadOrder(3); 
      Assert.AreEqual(10, myBreadOrder.BreadCost(3)); 
    }
  }
}