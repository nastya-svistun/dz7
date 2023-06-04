﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Clear();
// Console.WriteLine($"m = {m}, n = {n}.");
// double[,] array = new double[m, n];
// CreateArrayDouble(array);
// WriteArray(array);
// Console.WriteLine();

// void CreateArrayDouble(double[,] array)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().NextDouble() * 20 - 10;
//     }
//   }
// }

// void WriteArray (double[,] array){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         double alignNumber = Math.Round(array[i, j], 1);
//         Console.Write(alignNumber + " ");
//       }
//       Console.WriteLine();
//   }
// }





// Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] randomArray = new double[m, n];
// Console.Write("Введите позицию строки: ");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию столбца: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// void mas(int m, int n)
// {
//     int i, j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < n; j++)
//         {
//             randomArray[i, j] = rand.NextDouble();
//             Console.Write($"{randomArray[i, j]:F2} ");
//         }
//         Console.WriteLine();
//     }
// }
// mas(m, n);
// if (m2 < 1 || n2 < 1)
//     Console.Write("Позиции строк не могут быть отрицательными");
// else if (m2 <= m + 1 && n2 <= n + 1)
//     Console.Write($"Значение элемента равно {randomArray[m2 - 1, n2 - 1]:F2} ");
// else Console.Write("Такого элемента нет в массиве");





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// Console.WriteLine("введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[n, m];
// FillArrayRandomNumbers(numbers);


// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         avarage = (avarage + numbers[i, j]);
//     }
//     avarage = avarage / n;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();
// PrintArray(numbers);



// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }