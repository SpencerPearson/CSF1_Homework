using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main()
        {
            string[] fruits = { "Apple", "Orange", "Kiwi", "Banana", "Grape", "Pineapple" };

            for (int counter = 0; counter < 6; counter++)
            {
                Console.WriteLine(fruits[counter]);
            }
        }
        
    }
}
