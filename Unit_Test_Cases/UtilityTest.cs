using NUnit.Framework;
using System;
using MockFiles;
using System.IO.Abstractions.TestingHelpers;
using MFex_ZooAssignment.Utils;
using MFex_ZooAssignment.Service.Models;
using System.Collections.Generic;

namespace Unit_Test_Cases
{
    [TestFixture()]
    public class UtilityTest
    {
        [Test()]
        public void TestReadCSV()
        {
            List<AnimalFoodConsumptionModel> listOfAnimals = new List<AnimalFoodConsumptionModel>();
            listOfAnimals = utility.ReadCSV("/Users/jevu/Projects/MFex_ZooAssignment/Unit_Test_Cases/TestResources/TestAnimals.csv");           

            Assert.IsNotNull(listOfAnimals);
            Assert.AreEqual(listOfAnimals.Count,3);
            Assert.AreEqual(listOfAnimals[0].Animal, "Lion");
            Assert.AreEqual(listOfAnimals[0].FoodConsumptionRate, 0.10f);
            Assert.AreEqual(listOfAnimals[2].PercentageOfMeat, "90%");
        }

        [Test()]
        public void TestReadCSVNull()
        {
            List<AnimalFoodConsumptionModel> listOfAnimals = new List<AnimalFoodConsumptionModel>();
            listOfAnimals = utility.ReadCSV("/Users/jevu/Projects/MFex_ZooAssignment/Unit_Test_Cases/TestResources/TestAnimalsNull.csv");

            Assert.IsNotNull(listOfAnimals);
            Assert.AreEqual(listOfAnimals.Count, 2);
            Assert.AreEqual(listOfAnimals[0].Animal, "Giraffe");
            Assert.AreEqual(listOfAnimals[0].FoodConsumptionRate, 0.08f);
            Assert.AreEqual(listOfAnimals[1].PercentageOfMeat, "90%");
        }

        [Test()]
        public void TestReadCSVEmpty()
        {
            List<AnimalFoodConsumptionModel> listOfAnimals = new List<AnimalFoodConsumptionModel>();
            listOfAnimals = utility.ReadCSV("/Users/jevu/Projects/MFex_ZooAssignment/Unit_Test_Cases/TestResources/TestAnimalsEmpty.csv");

            Assert.AreEqual(listOfAnimals.Count, 0);

        }

        [Test()]
        public void TestReadXML()
        {
            List<AnimalModel> animalsList = new List<AnimalModel>();
            animalsList = utility.ReadXML("/Users/jevu/Projects/MFex_ZooAssignment/Unit_Test_Cases/TestResources/TestZoo.xml");

            Assert.IsNotNull(animalsList);
            Assert.AreEqual(animalsList.Count, 8);
            Assert.AreEqual(animalsList[0].Animaltype, "Lion");
            Assert.AreEqual(animalsList[0].Animalname, "Simba");
            Assert.AreEqual(animalsList[7].Weight, 0.5f);
        }

        [Test()]
        public void TestReadXMLNull()
        {
            List<AnimalModel> animalsList = new List<AnimalModel>();
            animalsList = utility.ReadXML("/Users/jevu/Projects/MFex_ZooAssignment/Unit_Test_Cases/TestResources/TestZooNull.xml");

            Assert.AreEqual(animalsList.Count, 6);
            Assert.AreEqual(animalsList[0].Animaltype, "Giraffe");
            Assert.AreEqual(animalsList[0].Animalname, "Anna");
            Assert.AreEqual(animalsList[5].Weight, 0.5f);
        }

        [Test()]
        public void TestReadXMLEmpty()
        {
            List<AnimalModel> animalsList = new List<AnimalModel>();
            animalsList = utility.ReadXML("/Users/jevu/Projects/MFex_ZooAssignment/Unit_Test_Cases/TestResources/TestZooEmpty.xml");

            Assert.AreEqual(animalsList.Count, 0);
        }


        [Test()]
        public void TestReadTextFile()
        {
            FoodRateModel foodRateModel = new FoodRateModel();

            foodRateModel = utility.ReadTextFile("/Users/jevu/Projects/MFex_ZooAssignment/Unit_Test_Cases/TestResources/TestPrices.txt");

            Assert.IsNotNull(foodRateModel);
            Assert.AreEqual(foodRateModel.FruitRate, 5.89f);
            Assert.AreEqual(foodRateModel.MeatRate, 16.78f);
        }

        [Test()]
        public void TestReadTextFileNull()
        {
            FoodRateModel foodRateModel = new FoodRateModel();

            foodRateModel = utility.ReadTextFile("/Users/jevu/Projects/MFex_ZooAssignment/Unit_Test_Cases/TestResources/TestPricesNull.txt");

            Assert.AreEqual(foodRateModel.FruitRate, 0f);
            Assert.AreEqual(foodRateModel.MeatRate, 0f);
        }

        [Test()]
        public void TestReadTextFileEmpty()
        {
            FoodRateModel foodRateModel = new FoodRateModel();

            foodRateModel = utility.ReadTextFile("/Users/jevu/Projects/MFex_ZooAssignment/Unit_Test_Cases/TestResources/TestPricesEmpty.txt");

            Assert.AreEqual(foodRateModel.FruitRate, 0f);
            Assert.AreEqual(foodRateModel.MeatRate, 0f);
        }
    }
}
