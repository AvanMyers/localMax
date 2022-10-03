using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayElements = 30;
            int minRandom = 0;
            int maxRandom = 50;
            Random random = new Random();
            int[] array = new int[arrayElements];
            string localMaximum = "";

            Console.Write("[ ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(minRandom, maxRandom);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");

            if (array[0] < array[1])
            {
                localMaximum += Convert.ToString(array[0] + " ");
            }
            for (int i = 1; i < array.GetLength(0) - 1; i++)
            {
                if (i < array.GetLength(0) - 1)
                {
                    if (array[i] <= array[i + 1] && array[i] <= array[i - 1])
                    {
                        localMaximum += Convert.ToString(array[i] + " ");
                    }
                } 
            }
            if (array[arrayElements - 1] < array[arrayElements - 2])
            {
                localMaximum += Convert.ToString(array[arrayElements] + " ");
            }
            Console.WriteLine(localMaximum);
            Console.ReadKey();
        }
    }
}
