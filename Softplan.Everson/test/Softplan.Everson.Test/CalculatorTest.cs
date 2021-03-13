using Microsoft.VisualStudio.TestTools.UnitTesting;
using Softplan.Everson.Domain.Services.Implementations;
using System;

namespace Softplan.Everson.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void GetInterestRateTest()
        {
            const decimal interestRate = 0.01m;
            var calculatorService = new CalculatorService(null);
            Assert.AreEqual(interestRate, calculatorService.GetInterestRate());
        }

        [TestMethod]
        public void CalculateInterestValueTest()
        {
            const decimal interestRate = 105.10m;
            var calculatorService = new CalculatorService(null);
            Assert.AreEqual(interestRate, calculatorService.CalculateInterest(100m, 5));
        }

        [TestMethod]
        public void CalculateInterestErrorMonthsTest()
        {
            var calculatorService = new CalculatorService(null);
            Assert.ThrowsException<ArgumentException>(() => calculatorService.CalculateInterest(100m, -6));
        }

        [TestMethod]
        public void CalculateInterestGenericErrorTest()
        {
            var calculatorService = new CalculatorService(null);
            Assert.ThrowsException<OverflowException>(() => calculatorService.CalculateInterest(100m, 147859));
        }
    }
}
