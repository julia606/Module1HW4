using System;

namespace ДЗ4
{
    internal class Program
    {
        public static char [] NumsToLetters(int[] arrayOfNums)
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

        public static void PrintArrayOfLetters(char[] array)
        {
            Console.Write("Массив букв: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }

        public static void PrintArrayOfNums(int[] array)
        {
            Console.Write("Массив рандомных чисел: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }

        public static void Main (string[] args)
        {
            Console.WriteLine("Введите любое число от 1 до 26 включительно: ");
            bool result = int.TryParse(Console.ReadLine(), out var n);
            if (result == false || n > 26 || n < 1)
            {
                Console.WriteLine("Вы ввели не число или число не из диапазона от 1 до 26, повторите попытку!");
            }
            else
            {
                int[] array = new int[n];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(1, 26);
                }

                PrintArrayOfNums(array);
                Console.WriteLine();
                PrintArrayOfLetters(NumsToLetters(array));
                Console.WriteLine();
            }
        }
    }
}
