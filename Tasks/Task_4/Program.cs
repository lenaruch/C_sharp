﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (n >= m && n >= b)
    Console.WriteLine($"Max: {n}");
else if (m >= n && m >= b)
    Console.WriteLine($"Max: {m}");
else if (b >= n && b >= m)
    Console.WriteLine($"Max: {b}");