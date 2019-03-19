/*Name: Alanis Correa Kriener
  Purpose: Continue using loops*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4class1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task Exponents
            Console.WriteLine("Number\tSquare\tCube\t\n______\t______\t____\t\n\n<< for loop >>>");
            

            double finish = 10;
            for (double i = 0; i <= finish; i++)
            {
                Console.WriteLine($"{i}\t{i * i}\t{i * i * i}");
            }

            Console.WriteLine("<< while loop >>>");
            int b = 0;
            while (b <=10)
            {
                Console.WriteLine($"{b}\t{b * b}\t{b * b * b}");
                b++;
            }

            Console.WriteLine("<< do while loop >>>");
            b = 0;
            do
            {
                Console.WriteLine($"{b}\t{b * b}\t{b * b * b}");
                b++;
            } while (b <= 10);

            Console.ReadLine();
            
            // Task Odd Numbers
            Console.WriteLine("Display odd numbers from 76 to 46");
            int c = 76;
            while (c <= 76 && c >= 46)
            {
                if(c%2 != 0)
                {
                    Console.WriteLine($"{c}");
                    c--;
                }
                else
                {
                    c--;
                }
                
            }
            Console.WriteLine("Program End");
            Console.ReadLine();

            // Task Repeat Character
            Console.WriteLine("Enter a character/symbol: ");
            string char1 = Console.ReadLine();
            Console.WriteLine("Enter the amount of times you would like to display this character: ");
            int num1 = int.Parse(Console.ReadLine()); 
            

            for (int i = 1; i < num1; i++)
            {
                Console.Write($"{char1}");
            }
            Console.ReadLine();
        }
    }
}
