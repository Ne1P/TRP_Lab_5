﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TRP_Lab_5
{
    class Data
    {
        public static int[,] ReadInput()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Petro\Desktop\Algoritm\TPR\Lab_5\TRP_Lab_5\TRP_Lab_5\input.txt");
            int[,] num = new int[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    num[i, j] = Convert.ToInt32(temp[j]);
            }
            // перевіримо вивівши дані на результат
            Console.WriteLine("Вхідні дані:");
            for (int i = 0; i < num.GetLength(0); i++)
            {

                for (int j = 0; j < num.GetLength(1); j++)
                    Console.Write(num[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
            return num;

        }
    }
}
