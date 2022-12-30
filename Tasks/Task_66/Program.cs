// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void GapNumberSum (int a, int b, int sum)
{
    if (a > b) 
    {
        Console.WriteLine($"Сумма натуральных элементов в заданном промежутке: {sum}"); 
        return;
    }
    sum = sum + (a++);
    GapNumberSum(a, b, sum);
}

Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

GapNumberSum(n, m, 0);