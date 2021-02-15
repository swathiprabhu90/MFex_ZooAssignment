using System;
using System.Collections.Generic;
using System.Linq;
using MFex_ZooAssignment.Service.Interface;
using MFex_ZooAssignment.Service.Models;

namespace MFex_ZooAssignment.Service.Implementation
{
    public class Omnivores: IAnimalsType
    {
        public Omnivores(ZooAnimal zooAnimal, FoodRateModel foodRate)
        {
            this.zooAnimal = zooAnimal;
            this.foodRate = foodRate;
        }

        private ZooAnimal zooAnimal;
        private FoodRateModel foodRate;
        

        public ZooAnimal CalculateFoodIntakeForDay()
        {
            float foodIntake;

            try
            {
                foodIntake = zooAnimal.AnimalModel.Weight * zooAnimal.AnimalModel.Animaldetails.FoodConsumptionRate;
                zooAnimal.MeatIntakeForDay = (foodIntake * float.Parse(zooAnimal.AnimalModel.Animaldetails.PercentageOfMeat.Split(Properties.PERCENTAGE)[0])) / 100;
                zooAnimal.FruitIntakeForDay = foodIntake - zooAnimal.MeatIntakeForDay;
                zooAnimal.PriceOfFoodForADay = ((zooAnimal.MeatIntakeForDay * foodRate.MeatRate) + (zooAnimal.FruitIntakeForDay * foodRate.FruitRate));
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }

            return zooAnimal;
        }
    }
}
