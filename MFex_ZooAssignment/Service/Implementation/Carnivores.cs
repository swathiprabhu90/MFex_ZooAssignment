using System;
using System.Collections.Generic;
using System.Linq;
using MFex_ZooAssignment.Service.Interface;
using MFex_ZooAssignment.Service.Models;

namespace MFex_ZooAssignment.Service.Implementation
{
    public class Carnivores : IAnimalsType
    {
        public Carnivores(ZooAnimal zooAnimal, FoodRateModel foodRate)
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
                zooAnimal.MeatIntakeForDay = zooAnimal.AnimalModel.Weight * zooAnimal.AnimalModel.Animaldetails.FoodConsumptionRate;
                zooAnimal.PriceOfFoodForADay = zooAnimal.MeatIntakeForDay * foodRate.MeatRate;
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }
            return zooAnimal;            
        }



    }
}
