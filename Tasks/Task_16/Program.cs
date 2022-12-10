// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n * n == m || m * m == n)
   Console.WriteLine("yes");
else
   Console.WriteLine("no");

// Альтернативный вариант решения
//Console.Clear();
//Console.Write("Введите 1-ое число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 2-ое число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//if (n * n == m)
//    Console.WriteLine("yes");
//else if (m * m == n)
//    Console.WriteLine("yes");
//else
//    Console.WriteLine("no");