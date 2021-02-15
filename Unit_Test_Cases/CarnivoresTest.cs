using NUnit.Framework;
using System;
using MockFiles;
using MFex_ZooAssignment.Service;
using System.IO.Abstractions.TestingHelpers;
using MFex_ZooAssignment.Service.Models;
using System.Collections.Generic;
using MFex_ZooAssignment.Service.Implementation;

namespace Unit_Test_Cases
{
    [TestFixture()]
    public class CarnivoresTest
    {
        [Test()]
        public void TestToPriceforADay()
        {
            FoodRateModel foodRate = new FoodRateModel { FruitRate = 10, MeatRate = 10 };
            AnimalFoodConsumptionModel animalFoodConsumptionModel = new AnimalFoodConsumptionModel("Lion",0.1f,"meat",null);
            
            ZooAnimal zooAnimal = new ZooAnimal(new AnimalModel( "Lion", "Simba", 140)
            { 
              Animaldetails = animalFoodConsumptionModel
            });

            Carnivores carnivores = new Carnivores(zooAnimal, foodRate);
            zooAnimal = carnivores.CalculateFoodIntakeForDay();

            Assert.AreEqual(zooAnimal.MeatIntakeForDay, 14);
            Assert.AreEqual(zooAnimal.PriceOfFoodForADay, 140);
        }
    }
}
