﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int n = new Random().Next(100, 1000); // [begin, end + 1] [100, 999]
Console.WriteLine($"Случаное число {n}");
int n1 = n / 100; // кол-во десятков
int n3 = n % 10; // кол-во едини
Console.WriteLine( (n - (n1 * 100) - n3) / 10 );