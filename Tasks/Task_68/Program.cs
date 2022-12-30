// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29




int AckermannFunction (int a, int b) // Метод вычисления функции Аккермана:
{
    if (a == 0) 
        return b + 1;
    if (a != 0 && b == 0) 
        return AckermannFunction(a - 1, 1);
    if (a > 0 && b > 0) 
        return AckermannFunction(a - 1, AckermannFunction(a, b - 1));
return AckermannFunction(a, b);
}
Console.Clear();
Console.Write("Введите начальное число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите начальное число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");