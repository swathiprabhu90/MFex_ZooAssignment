using System;
namespace MFex_ZooAssignment.Service.Models
{
    public class FoodRateModel
    {
        public FoodRateModel()
        {
        }

        private float meatRate;
        private float fruitRate;

        public float MeatRate
        {
            get { return meatRate; }
            set { meatRate = value; }
        }

        public float FruitRate
        {
            get { return fruitRate; }
            set { fruitRate = value; }
        }

        public float calculateFoodRate()
        {
            return meatRate + fruitRate;
        }

    }
}
