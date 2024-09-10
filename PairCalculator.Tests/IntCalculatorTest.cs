using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairCalculator;

namespace PairCalculator.Tests;

[TestClass]
[TestSubject(typeof(IntCalculator))]
public class IntCalculatorTest
{

    [TestMethod]
    public void Add()
    {
        // Arrange
        IntCalculator calculator = new IntCalculator();
        // Act
        calculator.Add(5);
        // Assert
        Assert.AreEqual(5, calculator.Result);
    }
}