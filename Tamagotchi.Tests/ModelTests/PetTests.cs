using System;// for IDisposable and Console.WriteLine()
using System.Collections.Generic;// for List<>
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests : IDisposable// ": IDisposable" allows for teardown between tests
  {

    public void Dispose()
    {
      // Automatically runs after every test
      Pet.ClearAll();// "ClearAll()" needs to be defined in Pet.cs
    }

    // Test methods
    [TestMethod]
    public void PetConstructor_CreatesInstanceOfPet_Pet()
    {
      // Act
      Pet newPet = new Pet("Michi", "Ramen", 10, 60);
      // Assert
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PetList()
    {
      // Arrange
      List<Pet> newList = new List<Pet> { };

      // Act
      List<Pet> result = Pet.GetAll();
      foreach (Pet thisPet in result)
      {// NOTE: Console.WriteLine only outputs to the terminal if the test fails
        Console.WriteLine("Output from empty list GetAll test: " + thisPet.Name);
      }

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_PetsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      Pet newPet = new Pet("Hachi", "Udon", 10, 60);

      //Act
      int result = newPet.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPet_Pet()
    {
      //Arrange
      Pet newPet1 = new Pet("Hachi", "Udon", 10, 60);
      Pet newPet2 = new Pet("Sachi", "Tempura", 10, 60);

      //Act
      Pet result = Pet.Find(2);

      //Assert
      Assert.AreEqual(newPet2, result);

    }
  }
}

//  [TestMethod]
//     public void Find_ReturnsCorrectItem_Item()
//     {
//       //Arrange
//       string description01 = "Walk the dog";
//       string description02 = "Wash the dishes";
//       Item newItem1 = new Item(description01);
//       Item newItem2 = new Item(description02);

//       //Act
//       Item result = Item.Find(2);

//       //Assert
//       Assert.AreEqual(newItem2, result);
//     }


