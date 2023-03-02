/* 
 * Author: Steven Gonzalez
 * Course: COMP-003A
 * Purpose: COMP003A.Assignment5
 */

using System;

namespace COMP003A.Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Triangle Section");
            Console.Write("Enter a character: ");
            char inputCharacter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a positive whole number: ");
            int size = Convert.ToInt32(Console.ReadLine());

            IsoscelesTriangleBuilder(inputCharacter, size);

            PrintSeparator("Favorite Characters Section");
            CharacterInfo("James", 1938);
            CharacterInfo("Tommy", 1939);
            CharacterInfo("Gonzen", 1941);
            CharacterInfo("Jon", 1962);
            CharacterInfo("Tobi", 1963);

        }
        static void PrintSeparator(string message)
        {
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(message);
            Console.WriteLine(new string('*', 50));
        }
         /// <summary>
        /// Method for providing a convenient way to output a message with a decorative separator in a console application.
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="size"></param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }

            for (int i = size - 1; i >= 1; i--)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
        }
         /// <summary>
        /// method that builds and outputs an isosceles triangle made of inputCharacters characters with a base od size
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static int AgeCalculator(int year)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - year;
        }
         /// <summary>
        /// method that calculates the age of a person or the number of years since some event occurred based on a given year aprameter and the current year.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthYear"></param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {age} this year!");
        }
    }
}
