using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Technology;

namespace TechnologyTests;

[TestClass]
public class UnitTest1
{
    Computer testComputer = new Computer(8, "Windows", true);
    SmartPhone testSmartPhone = new SmartPhone(12, "IOS", 3145788090, false);
    Laptop testLaptop = new Laptop(7, "Mountain Lion", 16, false);

    //Test 1
    [TestMethod]
    public void TestComputerCreation()
    {
        Assert.AreEqual(true, testComputer.IsTurnedOn);
        Assert.AreEqual(8, testComputer.OSVersionNumber);
        Assert.AreEqual("Windows", testComputer.OSName);
    }

    //Test 2
    [TestMethod]
    public void TestUpdate()
    {
        testComputer.UpdateOSVersion(9);
        Assert.AreEqual(9, testComputer.OSVersionNumber);
    }

    //Test 3
    [TestMethod]
    public void TestTogglePower()
    {
        testComputer.TogglePower();
        Assert.AreEqual(false, testComputer.IsTurnedOn);
    }

    //Test 4
    [TestMethod]
    public void TestIDMethodComputer()
    {
        Assert.AreEqual(1, testComputer.IDNumber);
    }

    //Test 5
    [TestMethod]
    public void TestInheritanceSmartphone()
    {
        Assert.AreEqual(12, testSmartPhone.OSVersionNumber);
    }

    //Test 6
    [TestMethod]
    public void TestInheritedMethodSmartPhone()
    {
        testSmartPhone.TogglePower();
        Assert.AreEqual(true, testSmartPhone.IsTurnedOn);
    }

    //Test 7
    [TestMethod]
    public void TestText()
    {
        testSmartPhone.Text("Test message", 3145788090);
        Assert.AreEqual("Test message", testSmartPhone.Message);
    }

    //Test 8
    [TestMethod]
    public void TestIDMethodSmartphone()
    {
        Assert.AreEqual(2, testSmartPhone.IDNumber);
    }

    //Test 9
    [TestMethod]
    public void TestInheritanceLaptop()
    {
        Assert.AreEqual("Mountain Lion", testLaptop.OSName);
    }

    //Test 10
    [TestMethod]
    public void TestInheritedMethodLaptop()
    {
        testLaptop.UpdateOSVersion(8);
        Assert.AreEqual(8, testLaptop.OSVersionNumber);
    }

    //Test 11
    [TestMethod]
    public void TestStorageIncrease()
    {
        testLaptop.IncreaseStorage(10);
        Assert.AreEqual(26, testLaptop.Storage);
    }

    //Test 12
    [TestMethod]
    public void TestIDMethodLaptop()
    {
        Assert.AreEqual(3, testLaptop.IDNumber);
    }

}
