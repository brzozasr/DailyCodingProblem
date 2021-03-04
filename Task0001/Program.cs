using System;

namespace Task0001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] {10, 15, 3, 7};
            int k = 17;
            var result = HasNumbers(numbers, k);
            Console.WriteLine($"Result: {result}");
        }

        private static bool HasNumbers(int[] numbers, int k)
        {
            int? tmp = null;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    tmp = numbers[i] + numbers[j];
                    Console.WriteLine($"{numbers[i]} + {numbers[j]} = {numbers[i] + numbers[j]}");

                    if (tmp == k)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}