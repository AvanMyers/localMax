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
            Random random = new Random();
            int[] array = new int[arrayElements];
            string localMaximum = "";

            Console.Write("[ ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == 0)
                {
                    if (array[0] < array[1]) 
                    { 
                    localMaximum += Convert.ToString(array[i] + " ");
                    }
                }
                if (i < array.GetLength(0) - 1)
                {
                    if (array[i] <= array[i + 1] && array[i] <= array[i - 1])
                    {
                        localMaximum += Convert.ToString(array[i] + " ");
                    }
                } 
                if (i == array.GetLength(0) - 1)
                {
                    if (array[i] < array[i - 1])
                    {
                        localMaximum += Convert.ToString(array[i] + " ");
                    }
                }
            }
            Console.WriteLine(localMaximum);
            Console.ReadKey();
        }
    }
}
