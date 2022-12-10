﻿// Задача 3: Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
   Console.Write("Вы ошиблись!\nВведите день недели: ");
   n = Convert.ToInt32(Console.ReadLine());
}

if (n == 1)
   Console.WriteLine("Понедельник");
else if (n == 2)
   Console.WriteLine("Вторник");
else if (n == 3)
   Console.WriteLine("Среда");
else if (n == 4)
   Console.WriteLine("Четверг");
else if (n == 5)
   Console.WriteLine("Пятница");
else if (n == 6)
   Console.WriteLine("Суббота");
else
   Console.WriteLine("Воскресенье");
