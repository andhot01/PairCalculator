using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairCalculator;

namespace PairCalculator.Tests;

[TestClass]
[TestSubject(typeof(IntCalculator))]
public class IntCalculatorTest
{

    [TestMethod]
    public void Modulus()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Modulus(5);
        // Assert
        Assert.AreEqual(0, calculator.Result);
    }
    
    [TestMethod]
    public void Subtract()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Subtract(5);
        // Assert
        Assert.AreEqual(-5, calculator.Result);
    }
    
    [TestMethod]
    public void Multiply()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Multiply(5);
        // Assert
        Assert.AreEqual(0, calculator.Result);
    }
    
    [TestMethod]
    public void Divide()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Divide(5);
        // Assert
        Assert.AreEqual(0, calculator.Result);
    }
    
    [TestMethod]
    public void DivideByZero()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(0));
    }
    
    [TestMethod]
    public void MultiplyOverflow()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Add(1000000);
        calculator.Multiply(1000000);
        // Assert
        Assert.AreEqual(-1, calculator.Result);
    }
    
    [TestMethod]
    public void SubtractNegative()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Subtract(-5);
        // Assert
        Assert.AreEqual(5, calculator.Result);
    }
    
    [TestMethod]
    public void AddNegative()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Add(-5);
        // Assert
        Assert.AreEqual(-5, calculator.Result);
    }
    
    [TestMethod]
    public void SubtractPositive()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Subtract(5);
        // Assert
        Assert.AreEqual(-5, calculator.Result);
    }
    
    [TestMethod]
    public void AddPositive()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Add(5);
        // Assert
        Assert.AreEqual(5, calculator.Result);
    }

    [TestMethod]
    public void ResetMemory()
    {
        IntCalculator calculator = new IntCalculator();
        calculator.Add(5);
        calculator.ResetMemory();
        Assert.AreEqual(0, calculator.Memory);
    }

    [TestMethod]
    public void MemoryAdd()
    {
        IntCalculator calculator = new IntCalculator();
        calculator.Add(5);
        calculator.MemoryAdd();
        Assert.AreEqual(5, calculator.Result);
    }
    
    [TestMethod]
    public void MemorySubtract()
    {
        IntCalculator calculator = new IntCalculator();
        calculator.Add(5);
        calculator.MemorySubtract();
        Assert.AreEqual(-5, calculator.Memory);
    }
}