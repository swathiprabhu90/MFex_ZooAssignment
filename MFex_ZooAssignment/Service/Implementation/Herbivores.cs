using System;
using System.Collections.Generic;
using System.Linq;
using MFex_ZooAssignment.Service.Interface;
using MFex_ZooAssignment.Service.Models;

namespace MFex_ZooAssignment.Service.Implementation
{
    public class Herbivores: IAnimalsType 
    {
        public Herbivores(ZooAnimal zooAnimal, FoodRateModel foodRate)
        {
            this.zooAnimal = zooAnimal;
            this.foodRate = foodRate;
        }

        private ZooAnimal zooAnimal;
        private FoodRateModel foodRate;
        
        public ZooAnimal CalculateFoodIntakeForDay()
        {
            try
            {
                zooAnimal.FruitIntakeForDay = zooAnimal.AnimalModel.Weight * zooAnimal.AnimalModel.Animaldetails.FoodConsumptionRate;
                zooAnimal.PriceOfFoodForADay = zooAnimal.FruitIntakeForDay * foodRate.FruitRate;
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }

            return zooAnimal;

        }


    }
}
