using System;
namespace MFex_ZooAssignment.Service.Models
{
    public class AnimalModel
    {
        public AnimalModel(string animalType, string animalname, float weight)
        {
            this.animalType = animalType;
            this.animalname = animalname;
            this.weight = weight;
        }

        private string animalname;
        private float weight;
        private string animalType;
        private AnimalFoodConsumptionModel animaldetails;

        public string Animaltype
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public string Animalname
        {
            get { return animalname; }
            set { animalname = value; }
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public AnimalFoodConsumptionModel Animaldetails
        {
            get { return animaldetails; }
            set { animaldetails = value; }
        }
    }
}
