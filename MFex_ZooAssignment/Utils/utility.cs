using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using MFex_ZooAssignment.Service.Models;

namespace MFex_ZooAssignment.Utils
{
    public static class utility
    {
        private const int V = 0;

        public static List<AnimalFoodConsumptionModel> ReadCSV (string inputFilePath)
        {
            List<AnimalFoodConsumptionModel> listOfAnimals = new List<AnimalFoodConsumptionModel>();
            List<string> values = null;
            try
            {
                using (StreamReader inputReader = File.OpenText(inputFilePath))
                {
                    while(!inputReader.EndOfStream)
                    {
                        string line = inputReader.ReadLine();

                        if (line.Contains(Properties.COMMASEPARATED)) { 
                            values = line.Split(Properties.COMMASEPARATED).ToList();

                            if (!string.IsNullOrWhiteSpace(values[0]))
                            { 
                                listOfAnimals.Add(new AnimalFoodConsumptionModel(
                                    values.ElementAt(0),
                                    float.Parse(values.ElementAt(1)),
                                    values.ElementAt(2), 
                                    values.ElementAt(3) ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }
            return listOfAnimals;
        }

        public static List<AnimalModel> ReadXML(string inputFilePath)
        {
            List<AnimalModel> animalsList = new List<AnimalModel>();
            bool val;

            try
            { 
                using (XmlReader xmlreader = XmlReader.Create(inputFilePath))
                { 
                    while (xmlreader.Read())
                    {
                        if (xmlreader.IsStartElement() && xmlreader.IsEmptyElement && !string.IsNullOrWhiteSpace(xmlreader.GetAttribute(0).ToString()))
                        {
                            val = float.TryParse(xmlreader.GetAttribute(1), out float value);
                            animalsList.Add(new AnimalModel(
                                xmlreader.Name.ToString(),
                                xmlreader.GetAttribute(0).ToString(),
                                value));
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }
            return animalsList;
        }

        public static FoodRateModel  ReadTextFile(string inputFilePath)
        {
            FoodRateModel foodRateModel = new FoodRateModel();
            bool val;
            try
            {
                using (StreamReader inputReader = File.OpenText(inputFilePath))
                {
                    while (!inputReader.EndOfStream)
                    {
                        string line = inputReader.ReadLine();
                        if (line.Contains(Properties.EQUAL) && line.Length > 1) {
                            var priceSplit = line.Split(Properties.EQUAL).ToList();
                            if (priceSplit[0] == Properties.MEAT && priceSplit.Count == 2)
                            {
                                val = float.TryParse(priceSplit[1], out float value);
                                foodRateModel.MeatRate = value;
                            }
                            else {
                                val = float.TryParse(priceSplit[1], out float value);
                                foodRateModel.FruitRate = value;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Properties.EXCMSG + ex.Message);
            }
            return foodRateModel;
        }
    }
}
