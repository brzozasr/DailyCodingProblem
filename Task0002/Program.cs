using System;
using System.Linq;
using System.Text;

namespace Task0002
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleInput1 = new int[] {1, 2, 3, 4, 5}; // Required output [120, 60, 40, 30, 24]
            var exampleInput2 = new int[] {3, 2, 1}; // Required output [2, 3, 6]

            var myResult1 = OutputArray(exampleInput1);
            var myResult2 = OutputArray(exampleInput2);
            
            PrintResult(myResult1);
            PrintResult(myResult2);
        }

        public static int[] OutputArray(int[] numbers)
        {

            var newArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                var tmpArray = new int[numbers.Length];
                Array.Copy(numbers, tmpArray, numbers.Length);

                var shortArray = tmpArray.Where((source, index) => index != i).ToArray();

                var tmpNumber = 1;
                foreach (var number in shortArray)
                {
                    tmpNumber *= number;
                }

                newArray[i] = tmpNumber;
            }
            
            return newArray;
        }

        public static void PrintResult(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            for (int i =0; i < numbers.Length; i++)
            {
                var result = numbers.Length - 1 == i ? $"{numbers[i]}" : $"{numbers[i]}, ";
                sb.Append(result);
            }

            sb.Append(']');
            Console.WriteLine(sb.ToString());
        }
    }
}