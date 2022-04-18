

using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { 
//  Дано предложение. Напишите рекурсивный метод, подсчитывающий
// количество слов в данном предложении. Словом считается последовательность символов без пробелов.

        

            string str = " Напишите рекурсивный метод,    подсчитывающий...  ";
            int i = 0;
            int count = 0;
            char spaceDel = ' ';
            str = str.Trim(spaceDel);

            if (str!= " ")
            {
            count = 1;
            }
            
            int count_word (string sentence)
            {
                if (i == sentence.Length ) return count++;
                else
                {
                    if (sentence[i] == ' ' && sentence[i+1] != ' ' ) count++;
                    i++;
                    return count_word (sentence);
                }

            }

            Console.WriteLine(count_word (str));


                


 



        }

    }
}