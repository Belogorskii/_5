/*1.Обязательная задача *.Сформировать одномерный массив из 7 элементов. 
Заполнить массив числами, вводимыми с клавиатуры, определить среднее 
арифметическое элементов.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int s = 0;
            int k = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
                k++;
            }
            Console.WriteLine(((double)s) / k);
            Console.ReadKey();
        }
    }
}


