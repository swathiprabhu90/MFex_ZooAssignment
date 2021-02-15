using NUnit.Framework;
using System;
using MockFiles;
using MFex_ZooAssignment.Service;
using System.IO.Abstractions.TestingHelpers;
using MFex_ZooAssignment.Service.Models;
using System.Collections.Generic;

namespace Unit_Test_Cases
{
    [TestFixture()]
    public class ProgramTest
    {
        [Test()]
        public void TestToPriceforADay()
        {
            float totalPrice;
            List<ZooAnimal> Animals = new List<ZooAnimal>();
            Zoo zoo = new Zoo(Animals);
            totalPrice = zoo.SpentFeedingOnAnimalsForADay();

            Assert.AreEqual(totalPrice,1609.00903f);
        }

        [Test()]
        public void TestForNullPriceValue()
        {
            float totalPrice;
            List<ZooAnimal> Animals = new List<ZooAnimal>();
            Zoo zoo = new Zoo(Animals);
            totalPrice = zoo.SpentFeedingOnAnimalsForADay();

            Assert.IsNull(totalPrice);
        }

    }
}
