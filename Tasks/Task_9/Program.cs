// Задача 9:Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

Console.Clear();
int n = new Random().Next(10, 100); // [begin, end + 1] [10, 99]
Console.WriteLine($"Случаное число {n}");
int n1 = n / 10; // кол-во десятков
int n2 = n % 10; // кол-во единиц
if (n1 > n2)
   Console.WriteLine(n1);
else
   Console.WriteLine(n2);