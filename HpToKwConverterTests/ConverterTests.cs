using Microsoft.VisualStudio.TestTools.UnitTesting;
using HpToKw;
using System;
using System.Collections.Generic;
using System.Text;

namespace HpToKw.Tests
{
    [TestClass()]
    public class ConverterTests
    {
        private string from;
        private string to;
        private double value;
        private double expectedValue;
        private double calculateResult;

        [TestMethod()]
        public void calculateTestWattToKw()
        {
            from = "Watt";
            to = "Kilowatt";
            value = 1000;
            expectedValue = 1;
            calculateResult = Converter.calculate(from,to,value);

            Assert.AreEqual(expectedValue, calculateResult);
        }
        [TestMethod()]
        public void calculateTestWattToMw()
        {
            from = "Watt";
            to = "Megawatt";
            value = 1000;
            expectedValue = 0.001;
            calculateResult = Converter.calculate(from, to, value);

            Assert.AreEqual(expectedValue, calculateResult);
        }
        [TestMethod()]
        public void calculateTestWattToGw()
        {
            from = "Watt";
            to = "Gigawatt";
            value = 100000;
            expectedValue = 0.0001;
            calculateResult = Converter.calculate(from, to, value);
            
            Assert.AreEqual(expectedValue, calculateResult);
        }
        /*
        [TestMethod()]
        public void calculateTestWattToHpM()
        {
            from = "Watt";
            to = "Horse_power_metric";
            value = 100000;
            expectedValue = 135.96211551613;
            calculateResult = Converter.calculate(from, to, value);

            Assert.AreEqual(expectedValue, calculateResult);
        }
        */
        [TestMethod()]
        public void calculateTestKwattToW()
        {
            from = "Kilowatt";
            to = "Watt";
            value = 1;
            expectedValue = 1000;
            calculateResult = Converter.calculate(from, to, value);

            Assert.AreEqual(expectedValue, calculateResult);
        }
        [TestMethod()]
        public void calculateTestKwattToMw()
        {
            from = "Kilowatt";
            to = "Megawatt";
            value = 1;
            expectedValue = 0.001;
            calculateResult = Converter.calculate(from, to, value);

            Assert.AreEqual(expectedValue, calculateResult);
        }
    }
}