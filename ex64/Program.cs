using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        {

            // Задайте значения M и N. Напишите программу, которая выведет все 
            // натуральные числа кратные 3-ём в промежутке от M до N.

            int M = 1;
            int N = 50;

            Recursia (M, N);

            void Recursia (int numberM, int numberN)

            {
                if(numberM%3==0) Console.WriteLine(numberM);
                if(numberM==numberN) return;
                Recursia (numberM+1, numberN);

            }

        }
    }
}