using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingCompany.Models;
using System;


namespace ShippingCompany.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel(5, 4, 3);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }

    [TestMethod]
    public void GetVolume_ReturnsDimensions_Int()
    {
      Parcel newParcel = new Parcel(5, 4, 3);
      int testNumber = 60;
      Assert.AreEqual(testNumber, newParcel.GetVolume());
    }

    [TestMethod]
    public void CostToShip_ReturnsCostToShip_Double()
    {
      Parcel newParcel = new Parcel(5, 4, 3);
      double testVolume = newParcel.GetVolume();
      double testNumber = .6;
      Assert.AreEqual(testNumber, newParcel.CostToShip());
    }
  }
}


// Example test format:

/*

[TestMethod]
public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
{
  // any necessary logic to prep for test; instantiating new classes, etc.
  Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
}

 */