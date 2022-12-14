using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCSharp
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Задание 4: " + TaskFour(942));
            Console.WriteLine("Задание 6: " + TaskSix(42145));
            Console.WriteLine("Задание 7: " + TaskSeven(2));
            Console.WriteLine("Задание 8: " + TaskEight());
            Console.ReadKey();
        }

        static int TaskFour(int num)
        {
            if (num < 1)
            {
                throw new Exception("Число не является натуральным");
            }

            int[] numbers = num.ToString().Select(i => int.Parse(i.ToString())).ToArray();
            int res = numbers.Aggregate(0, (acc, i) => acc + i);

            if (res.ToString().Length > 1)
            {
                return TaskFour(res);
            }

            return res;
        }

        static int TaskSix(int num)
        {
            if (num < 0)
            {
                throw new Exception("Число отрицательное");
            }

            int[] numbers = num.ToString().Select(i => int.Parse(i.ToString())).ToArray();

            Array.Sort(numbers);
            Array.Reverse(numbers);

            return int.Parse(String.Join("", numbers));
        }

        static int TaskSeven(int idx)
        {
            if (idx == 0)
            {
                return 0;
            }

            int[][] piramid = new int[][] {
                new int[] { 1 },
                new int[] { 3, 5 },
                new int[] { 7, 9, 11 },
                new int[] { 13, 15, 17, 19 },
                new int[] { 21, 23, 25, 27, 29 }
            };

            int[] row = piramid[idx - 1];
            return row.Aggregate(0, (acc, i) => acc + i);
        }

        static int TaskEight()
        {
            return "docru".Length;
        }
    }
}