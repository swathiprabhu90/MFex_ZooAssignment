using System;
using System.Collections.Generic;
using System.Linq;
using MFex_ZooAssignment.Service.Interface;
using MFex_ZooAssignment.Service.Models;

namespace MFex_ZooAssignment.Service.Implementation
{
    public class CreatAnimal: ICreatAnimal 
    {
        public CreatAnimal(List<AnimalModel> animals, List<ZooAnimal> zooAnimals, FoodRateModel foodRate)
        {
            this.animals = animals;
            this.zooAnimals = zooAnimals;
            this.foodRate = foodRate;
        }

        private List<AnimalModel> animals;
        private List<ZooAnimal> zooAnimals;
        private FoodRateModel foodRate;

        private void CreateMeatEatingAnimals()
        {
            try
            {
                var MeatEatingAnimals = animals.Where(x => x.Animaldetails.FoodIntake == "meat").ToList();

                foreach (var animal in MeatEatingAnimals)
                {
                    ZooAnimal zooAnimal = new ZooAnimal(animal);
                    IAnimalsType iAnimalsType = new Carnivores(zooAnimal, foodRate);
                    zooAnimals.Add(iAnimalsType.CalculateFoodIntakeForDay());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }
        }

        private void CreateFruitEatingAnimals()
        {
            try
            {
                var FruitEatingAnimals = animals.Where(x => x.Animaldetails.FoodIntake == "fruit").ToList();

                foreach (var animal in FruitEatingAnimals)
                {
                    ZooAnimal zooAnimal = new ZooAnimal(animal);
                    IAnimalsType iAnimalsType = new Herbivores(zooAnimal, foodRate);
                    zooAnimals.Add(iAnimalsType.CalculateFoodIntakeForDay());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }
        }

        private void CreateBothEatingAnimals()
        {
            try
            {

                var BothEatingAnimals = animals.Where(x => x.Animaldetails.FoodIntake == "both").ToList();

                foreach (var animal in BothEatingAnimals)
                {
                    ZooAnimal zooAnimal = new ZooAnimal(animal);
                    IAnimalsType iAnimalsType = new Omnivores(zooAnimal, foodRate);
                    zooAnimals.Add(iAnimalsType.CalculateFoodIntakeForDay());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }
        }
        
        public List<ZooAnimal> CreateZooAnimals()
        {
            try
            {
                CreateBothEatingAnimals();
                CreateFruitEatingAnimals();
                CreateMeatEatingAnimals();
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }

            return zooAnimals;
        }
    }   
}