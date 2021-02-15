using System.Resources;
using MFex_ZooAssignment.Utils;
using MFex_ZooAssignment.Service.Interface;
using System.Collections.Generic;
using MFex_ZooAssignment.Service.Models;
using System.Linq;
using MFex_ZooAssignment.Service.Implementation;
using System;

namespace MFex_ZooAssignment.Service
{
    public class Zoo
    {
        public Zoo(List<ZooAnimal> zooAnimals)
        {
            this.zooAnimals = zooAnimals;
        }


        private List<ZooAnimal> zooAnimals;


        public float SpentFeedingOnAnimalsForADay()
        {
            float priceForADayForAllAnimals = 0;
            FoodRateModel foodRate = null;
            List<AnimalModel> animals = null;
            List<AnimalFoodConsumptionModel> animalFoodConsumptions = null;

            try
            {
                animalFoodConsumptions = utility.ReadCSV(Properties.PATHCSV);
                animals = utility.ReadXML(Properties.PATHXML);

                foreach (AnimalModel animalmodel in animals)
                {
                    animalmodel.Animaldetails = animalFoodConsumptions.Where(x => x.Animal == animalmodel.Animaltype).First();
                }

                foodRate = utility.ReadTextFile(Properties.PATHTXT);

                ICreatAnimal creatAnimal = new CreatAnimal(animals, zooAnimals, foodRate);
                zooAnimals = creatAnimal.CreateZooAnimals();

                priceForADayForAllAnimals = zooAnimals.Sum(x => x.PriceOfFoodForADay);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }

            return priceForADayForAllAnimals;
        }



    }
}
