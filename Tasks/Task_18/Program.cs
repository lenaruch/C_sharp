// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1 || n == 2)
    Console.WriteLine("y > 0");
else
    Console.WriteLine("y < 0");

if (n == 1 || n == 4)
    Console.WriteLine("x > 0");
else
    Console.WriteLine("x < 0");