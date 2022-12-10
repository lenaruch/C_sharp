// https://gbcdn.mrgcdn.ru/uploads/record/227729/attachment/b586f6ef1c587ae2e802c0a0a5c19e29.mp4
// Урок 4. Функции

// Array

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1, 10]

// Console.WriteLine($"[{string.Join(", ", array)}]");


// Array
// Double numbers Генерация дробных чисел
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// for (int i = 0; i < array.Length; i++)
// {
//     //                                              * (end - begin) + begin
//     array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2); // [10, 50]
// }

// Console.WriteLine($"[{string.Join(", ", array)}]");


// Function
// Необходимо вывести наибольшее число из 2-х

// char test(int a, int b=10)
// {
//     if (a > b)
//         return '>';
//     return '<';
// }

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(test(n));
// // 1. return
// //       * Возвращает аргумент туда, где была вызвана функция
// //       * Завершает работу функции
// //       * Возвращаемое значение необходимо принимать в консоль(вывод) или в переменную нужного типа данных
// //       * Сколько аргументов мы принимаем, столько и передаем



// void test(ref int a)
// {
//     a += 5;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// test(ref n);
// Console.WriteLine(n);

// ***********************************************************************************************

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine((1 + n) / 2 * n);

// ***********************************************************************************************

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 0;
// while (n > 0)
// {
//     count++;
//     n /= 10;
// }
// Console.WriteLine(count);

// ***********************************************************************************************

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), result = 1;
// for (int i = 2; i <= n; i++)
//     result = result * i;
// Console.WriteLine(result);

// ***********************************************************************************************

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 2); // [0, 1]
// Console.WriteLine($"[{string.Join(", ", array)}]");

// ***********************************************************************************************

// Для решения доп.задач на сайте. Свой кусок кода нужно вставить в { }

// using System;
// public class Sum{
//   private static void Main(){
//     string[] tokens = Console.ReadLine().Split(' ');
//     Console.WriteLine(int.Parse(tokens[0]) + int.Parse(tokens[1]));
//   }
// }