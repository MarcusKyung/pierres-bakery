using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PasteriesTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPasry_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryOrder_ReturnsPastryOrder_Int()
    {
      //Arrange
      int count = 3;
      Pastry newPastry = new Pastry(count);
      //Act
      int result = newPastry.Pastries;
      //Assert
      Assert.AreEqual(count, result);
    }
  }
}