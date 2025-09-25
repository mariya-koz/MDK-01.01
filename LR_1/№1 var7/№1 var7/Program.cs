using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_var7
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           1. С клавиатуры ввести массив из n вещественных чисел. Найти разницу между максимальным и минимальным элементом массива.
           */
            Console.Write("Сколко элементов будет в массиве? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[n];
            Console.Write("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0];
            for (int i = 1; i < n; i++) 
            {
                if (array[i] > max) max = array[i];
            }
            int min = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] < min) min = array[i];
            }
        }
    }
}
