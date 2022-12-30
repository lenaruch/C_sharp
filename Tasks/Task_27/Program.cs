// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Мое решение:
Console.Clear();
Console.Write("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine()); // запись в "n" введенное пользователем значения
int n = 0; // если верхню строку раскомментировать, то эту строку нужно закоментировать, иначе в "n" запишется 0
int.TryParse(Console.ReadLine(), out n); // Пробуем конвертировать в число, если не получилось, то в переменную "n" запишется значение "0"
int sum = 0;
while (n > 0)
{
    sum = sum + n % 10;
    n = n / 10;
}
Console.WriteLine(sum);

// Решение от преподователя
// Console.Clear();
// Console.Write("Введите число: ");
// string? s = Console.ReadLine();
// int res = 0;
// for (int i = 0; i < s.Length; i++)
// {
//     res = res + Convert.ToInt32(s[i].ToString());
// }
// Console.WriteLine(res);

// Решение от преподователя через РЕКУРСИЮ
// int rec(int n)
// {
//     if (n / 10 == 0 || n < 10 || n % 10 == n)
//         return n;
//     return rec(n / 10) + n % 10;
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));