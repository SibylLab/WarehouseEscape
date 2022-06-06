using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseGameplay.Helpers
{
    public class RandomNumber
    {
       
        public static List<int> RandomVal()
        {
            Random randomNumber = new Random();
            List<int> rendomNuberList = new List<int>();
            for (int i = 0; i < 8; i++)
            {
               var rendonList = randomNumber.Next(100, 1000);
               rendomNuberList.Add(rendonList);
            }
            return rendomNuberList;
        }
        public static List<int> RandomValQuickSort()
        {
            Random randomNumber = new Random();
            List<int> rendomNuberList = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                var rendonList = randomNumber.Next(40, 100);
                rendomNuberList.Add(rendonList);
            }
            return rendomNuberList;
        }
    }
}
