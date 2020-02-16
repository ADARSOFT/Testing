using System;
using System.Collections.Generic;
using ManualTestingExamples.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PrviTest
    {
        [TestMethod]
        public void TestiranjePoslednje3PLate()
        {
            var sanjaIncome = new List<Salary>();
            var expectedAverage = 50000;

            sanjaIncome.Add(new Salary() { Amount = 45000, Date = DateTime.Now.AddDays(-120)});
            sanjaIncome.Add(new Salary() { Amount = 50000, Date = DateTime.Now.AddDays(-90) });
            sanjaIncome.Add(new Salary() { Amount = 50000, Date = DateTime.Now.AddDays(-60) });
            sanjaIncome.Add(new Salary() { Amount = 50000, Date = DateTime.Now.AddDays(-30) });

            var actual = FindAverageSalaryIncome.Last3Income(sanjaIncome);

            Assert.AreEqual(expectedAverage, actual);
        }
    }
}
