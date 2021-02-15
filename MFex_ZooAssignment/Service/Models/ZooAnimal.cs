using System;

namespace MFex_ZooAssignment.Service.Models
{
    public class ZooAnimal
    {
        public ZooAnimal(AnimalModel animal)
        {
            this.animalmodel = animal;
        }

        private AnimalModel animalmodel;
        private float fruitIntakeforDay;
        private float meatIntakeforDay;
        private float priceOfFoodForADay;

        public AnimalModel AnimalModel
        {
            get { return animalmodel; }
            set { animalmodel = value; }
        }

        public float FruitIntakeForDay
        {
            get { return fruitIntakeforDay; }
            set { fruitIntakeforDay = value; }
        }

        public float MeatIntakeForDay
        {
            get { return meatIntakeforDay; }
            set { meatIntakeforDay = value; }
        }

        public float PriceOfFoodForADay
        {
            get { return priceOfFoodForADay; }
            set { priceOfFoodForADay = value; }
        }

    }
}
