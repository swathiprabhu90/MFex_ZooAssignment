using NUnit.Framework;
using MFex_ZooAssignment.Service.Models;
using MFex_ZooAssignment.Service.Implementation;

namespace Unit_Test_Cases
{
    [TestFixture()]
    public class HerbivoresTest
    {
        [Test()]
        public void TestToPriceforADay()
        {
            FoodRateModel foodRate = new FoodRateModel { FruitRate = 10, MeatRate = 10 };
            AnimalFoodConsumptionModel animalFoodConsumptionModel = new AnimalFoodConsumptionModel("Zebra", 0.08f,"fruit",null);
            
            ZooAnimal zooAnimal = new ZooAnimal(new AnimalModel( "Zebra", "Zimba", 100)
            { 
              Animaldetails = animalFoodConsumptionModel
            });

            Herbivores herbivores = new Herbivores(zooAnimal, foodRate);
            zooAnimal = herbivores.CalculateFoodIntakeForDay();

            Assert.AreEqual(zooAnimal.FruitIntakeForDay, 8);
            Assert.AreEqual(zooAnimal.PriceOfFoodForADay, 80);
        }
    }
}
