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
  }
}