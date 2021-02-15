using System;
namespace MFex_ZooAssignment.Service.Models
{
    public class AnimalFoodConsumptionModel
    {
        public AnimalFoodConsumptionModel(string animal, float foodConsumptionRate, string foodIntake, string percentageOfMeat)
        {
            this.animal = animal;
            this.foodConsumptionRate = foodConsumptionRate;
            this.foodIntake = foodIntake;
            this.percentageOfMeat = percentageOfMeat;
        }

        private string animal;
        private float foodConsumptionRate;
        private string foodIntake;
        private string percentageOfMeat;

        public string Animal
        {
            get { return animal; }
            set { animal = value; }
        }

        public float FoodConsumptionRate
        {
            get { return foodConsumptionRate; }
            set { foodConsumptionRate = value; }
        }

        public string FoodIntake
        {
            get { return foodIntake; }
            set { foodIntake = value; }
        }

        public string PercentageOfMeat
        {
            get { return percentageOfMeat; }
            set { percentageOfMeat = value; }
        }
    }
}
