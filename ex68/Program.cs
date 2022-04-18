using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        {

            // Задайте значения M и N. Напишите программу, которая найдёт 
            // сумму натуральных элементов в промежутке от M до N.

            int M = 3;
            int N = 3;
            
 

            int Akkerman (int numberM, int numberN)

            {
                
                if(numberM==0) return numberN+1 ;
                else if (numberM>0 && numberN==0) return Akkerman (numberM - 1, 1);
                else return Akkerman (numberM - 1,  Akkerman (numberM, numberN-1));
                

            }
            Console.WriteLine(Akkerman (M, N));

        }
    }
}