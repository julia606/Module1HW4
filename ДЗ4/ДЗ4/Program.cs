// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ДЗ4
{
    using System;

    /// <summary>
    /// Main class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Converts all numbers in array to letters.
        /// </summary>
        /// <param name="arrayOfNums">Array of input numbers.</param>
        /// <returns>New array of chars based on array of numbers.</returns>
        public static char[] NumsToLetters(int[] arrayOfNums)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string specialLetters = "aeidhj";
            char[] arrayOfLetters = new char[arrayOfNums.Length];

            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                arrayOfLetters[i] = letters[arrayOfNums[i] - 1];
                if (specialLetters.Contains(arrayOfLetters[i]))
                {
                    arrayOfLetters[i] = char.ToUpper(arrayOfLetters[i]);
                }
            }

            return arrayOfLetters;
        }

        /// <summary>
        /// Prints array of letters.
        /// </summary>
        /// <param name="array">Array of chars.</param>
        public static void PrintArrayOfLetters(char[] array)
        {
            Console.Write("Массив букв: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }

        /// <summary>
        /// Prints array of numbers.
        /// </summary>
        /// <param name="array">Array of input numbers.</param>
        public static void PrintArrayOfNums(int[] array)
        {
            Console.Write("Массив рандомных чисел: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }

        /// <summary>
        /// Gets array of random numbers.
        /// </summary>
        /// <param name="n">Array of input numbers.</param>
        /// <returns>New random array.</returns>
        public static int[] GetRandomArray(int n)
        {
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 26);
            }

            return array;
        }

        /// <summary>
        /// Main function.
        /// </summary>
        /// <param name="args">.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число от 1 до 26 включительно: ");
            bool result = int.TryParse(Console.ReadLine(), out var n);
            if (result == false || n > 26 || n < 1)
            {
                Console.WriteLine("Вы ввели не число или число не из диапазона от 1 до 26, повторите попытку!");
            }
            else
            {
                PrintArrayOfNums(GetRandomArray(n));
                Console.WriteLine();
                PrintArrayOfLetters(NumsToLetters(GetRandomArray(n)));
                Console.WriteLine();
            }
        }
    }
}
