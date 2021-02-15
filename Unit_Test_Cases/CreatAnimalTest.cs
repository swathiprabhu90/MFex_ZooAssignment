using NUnit.Framework;
using MFex_ZooAssignment.Service.Models;
using MFex_ZooAssignment.Service.Implementation;
using System.Collections.Generic;

namespace Unit_Test_Cases
{
    [TestFixture()]
    public class CreatAnimalTest
    {
        [Test()]
        public void TestForCreateHerbivoresAnimal()
        {
            FoodRateModel foodRate = new FoodRateModel { FruitRate = 20, MeatRate = 10 };
            AnimalFoodConsumptionModel animalFoodConsumptionModel = new AnimalFoodConsumptionModel("zebra", 0.05f,"fruit",null);
            List<AnimalModel> animalModels = new List<AnimalModel>
            {
                new AnimalModel("zebra", "Zinba", 150)
                {
                    Animaldetails = animalFoodConsumptionModel
                }
            };

            List<ZooAnimal> zooAnimal = new List<ZooAnimal>
            {
                
            };

            List<ZooAnimal> resultZooAnimal = new List<ZooAnimal>();
            CreatAnimal herbivores = new CreatAnimal(animalModels, zooAnimal,foodRate);
            resultZooAnimal = herbivores.CreateZooAnimals();

            Assert.AreEqual(resultZooAnimal.Count, 1);
        }

        [Test()]
        public void TestForCreateOmnivoresAnimal()
        {
            FoodRateModel foodRate = new FoodRateModel { FruitRate = 20, MeatRate = 10 };
            AnimalFoodConsumptionModel animalFoodConsumptionModel = new AnimalFoodConsumptionModel("wolf", 0.05f, "both", "50%");
            List<AnimalModel> animalModels = new List<AnimalModel>
            {
                new AnimalModel("wolf", "Winba", 50)
                {
                    Animaldetails = animalFoodConsumptionModel
                }
            };

            List<ZooAnimal> zooAnimal = new List<ZooAnimal>
            {

            };

            List<ZooAnimal> resultZooAnimal = new List<ZooAnimal>();
            CreatAnimal omnivores = new CreatAnimal(animalModels, zooAnimal, foodRate);
            resultZooAnimal = omnivores.CreateZooAnimals();

            Assert.AreEqual(resultZooAnimal.Count, 1);
        }

        [Test()]
        public void TestForCreateCarnivoresAnimal()
        {
            FoodRateModel foodRate = new FoodRateModel { FruitRate = 20, MeatRate = 10 };
            AnimalFoodConsumptionModel animalFoodConsumptionModel = new AnimalFoodConsumptionModel("tiger", 0.05f, "meat", null);
            List<AnimalModel> animalModels = new List<AnimalModel>
            {
                new AnimalModel("tiger", "tinba", 100)
                {
                    Animaldetails = animalFoodConsumptionModel
                }
            };

            List<ZooAnimal> zooAnimal = new List<ZooAnimal>
            {

            };

            List<ZooAnimal> resultZooAnimal = new List<ZooAnimal>();
            CreatAnimal carnivores = new CreatAnimal(animalModels, zooAnimal, foodRate);
            resultZooAnimal = carnivores.CreateZooAnimals();

            Assert.AreEqual(resultZooAnimal.Count, 1);
        }
    }
}
