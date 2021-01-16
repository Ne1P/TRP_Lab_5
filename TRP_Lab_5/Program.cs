using System;
using System.Linq;
using System.Text;

namespace TRP_Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[,] input=Data.ReadInput();

            searchSaddlePoint(input);

            Console.ReadLine();
        }

        public static void searchSaddlePoint(int[,] input)
        {
            int[] minA = new int[5];
            int[] maxB = new int[5];

            int temp =99;


            for (int i = 0; i < minA.Length; i++)
            {
                for (int j = 0; j < maxB.Length; j++)
                {
                    if (temp > input[i, j])
                    {
                        temp = input[i, j];
                    }
                }
                minA[i] = temp;
                temp = 99;

            }

            temp = 0;
            for (int i = 0; i < maxB.Length; i++)
            {
                for (int j = 0; j < minA.Length; j++)
                {
                    if (temp < input[j, i])
                    {
                        temp = input[j, i];
                    }
                }
                maxB[i] = temp;
                temp = 0;
            }

            int maxInMinA = minA.Max();
            int indexMaxA = Array.IndexOf(minA, maxInMinA);
            
            int minInMaxB = maxB.Min();
            int indexMinB = Array.IndexOf(maxB, minInMaxB);
            
            // test Print

            for (int i = 0; i < minA.Length; i++)
            {
                for (int j = 0; j < maxB.Length; j++)
                {
                    Console.Write(input[i, j] + "\t");
                }
                Console.WriteLine("| "+minA[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < maxB.Length; i++)
            {
                Console.Write(maxB[i] + "\t");
            }
            Console.WriteLine();

            // End

            Console.WriteLine();
            Console.WriteLine("Нижня ціна гри, гравця А= " + maxInMinA + "\t із стратегії А" + (indexMaxA+1));
            Console.WriteLine("Верхня ціна гри, гравця B= " + minInMaxB + "\t із стратегії B" + (indexMinB+1));
            Console.WriteLine();
            if (maxInMinA != minInMaxB)
                Console.WriteLine("Оскільки визначені стратегії гравців не рівні, то сідлова точка не існує.\n" +
                    "Відповідно гра не має рішення в чистих стратегіях");
            else
            {
                Console.WriteLine("Проводимо пошук чистих стратегій.");
                // Тут має викликатися функція для пошуку чистих стратегій , але оскільк у мене не інує сідлової точки , реалізовувати її не буду.
            } 
        }

        public static void searchOptimalStrategy(int[,] input){

        }
}
}
