using System;// for IDisposable and Console.WriteLine()
using System.Collections.Generic;// for List
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests// : IDisposable// " : IDisposable" allows for teardown between tests
  {

    // public void Dispose()
    // {
    //   // Automatically runs after every test
    //   Pet.ClearAll();// "ClearAll()" needs to be defined in Item.cs
    // }

    // Test methods
    [TestMethod]
    public void PetConstructor_CreatesInstanceOfPet_Pet()
    {
      // Act
      Pet newPet = new Pet("Michi", "Ramen", 10, 60);
      // Assert
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }
  }
}