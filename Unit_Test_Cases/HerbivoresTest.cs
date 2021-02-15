using NUnit.Framework;
using MFex_ZooAssignment.Service.Models;
using MFex_ZooAssignment.Service.Implementation;

namespace Unit_Test_Cases
{
    [TestFixture()]
    public class OmnivoresTest
    {
        [Test()]
        public void TestToPriceforADay()
        {
            FoodRateModel foodRate = new FoodRateModel { FruitRate = 20, MeatRate = 10 };
            AnimalFoodConsumptionModel animalFoodConsumptionModel = new AnimalFoodConsumptionModel("wolf", 0.05f,"fruit","50%");
            
            ZooAnimal zooAnimal = new ZooAnimal(new AnimalModel("wolf", "Winba", 50)
            { 
              Animaldetails = animalFoodConsumptionModel
            });

            Omnivores omnivores = new Omnivores(zooAnimal, foodRate);
            zooAnimal = omnivores.CalculateFoodIntakeForDay();

            Assert.AreEqual(zooAnimal.FruitIntakeForDay, 1.25f);
            Assert.AreEqual(zooAnimal.MeatIntakeForDay, 1.25f);
            Assert.AreEqual(zooAnimal.PriceOfFoodForADay, 37.5f);
        }
    }
}
