using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2.Дана последовательность из 2500 случайных чисел от - 2000 до 2000.Сохранить в отдельной структуре данных все числа,
            оканчивающиеся на цифру 4.Результат вывести на экран в формате: [a1, a2, a3, ….., an], где а – очередное найденное число.*/
            int[] rand = new int[2500];
            for (int i = 0; i < rand.Length; i++)
            {
                Random rnd = new Random();
                rand[i] = rnd.Next(-2000, 2000);
            }
        }
    }
}
