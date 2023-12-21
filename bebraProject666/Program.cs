using System;
using System.Collections.Generic;

namespace bebraProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] existingArray = { -2, -4, 0, 1, 2, 3, 4, 5, 9, 55 };
            List<int> numbersList = new List<int>();

           
            foreach (int element in existingArray)
            {
                numbersList.Add(element);
            }

            // Удаляем нули из списка
            numbersList.RemoveAll(item => item == 0);

            // Выводим все элементы 
            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
