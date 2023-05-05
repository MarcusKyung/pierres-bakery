using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadsTests
  {
    [TestMethod]
    public void BreadsConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrder_Int()
    {
      //Arrange
      int quantity = 3;
      Bread newBread = new Bread(quantity);
      //Act
      int result = newBread.Loafs;
      //Assert
      Assert.AreEqual(quantity, result);
    }
  }
}
