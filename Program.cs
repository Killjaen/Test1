using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            Random random = new Random();

            for (int i = 0; i < mas.Length; i++) // заганяємо в массив рандомні числа
            {
                mas[i] = random.Next(15); // закидуєм в масив рандомні числа в діапазоні від 0 до 15
            }

            for (int i = 0; i < mas.Length; i++) // виводимо масив на екран
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();

            for (int i = mas.Length-1; i >= 0; i--)
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("test brunc added");
        }
    }
}
