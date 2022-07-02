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
  }
}