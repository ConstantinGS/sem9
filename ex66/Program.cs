using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        {

            // Задайте значения M и N. Напишите программу, которая найдёт 
            // сумму натуральных элементов в промежутке от M до N.

            int M = 1;
            int N = 50;
            int sum = 0;

            Recursia (M, N);

            void Recursia (int numberM, int numberN)

            {
                sum+=numberM;
                if(numberM==numberN) return;
                Recursia (numberM+1, numberN);

            }
            Console.WriteLine(sum);

        }
    }
}