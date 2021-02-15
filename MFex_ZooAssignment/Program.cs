using System;
using System.Collections.Generic;
using MFex_ZooAssignment.Service;
using MFex_ZooAssignment.Service.Models;

namespace MFex_ZooAssignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<ZooAnimal> Animals = new List<ZooAnimal>();
            float totalPrice;
            try
            {
                Zoo zoo = new Zoo(Animals);
                totalPrice = zoo.SpentFeedingOnAnimalsForADay();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine(Properties.SUCMSG + totalPrice);
        }
    }   

}


