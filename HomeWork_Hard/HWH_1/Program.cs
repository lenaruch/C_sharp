// Найти второй максимум 
Console.Clear();

Console.WriteLine("Введите числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max2 = 0;
while (n != 0)
{
    if (n > max1)
    {
        max2 = max1;
        max1 = n;
    }
    else if (n > max2)
    {
        max2 = n;
    }
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Значение второго максимального: {max2}");


// task dop
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), max1 = n, max2 = -1;
// while (n != 0)
// {
//     n = Convert.ToInt32(Console.ReadLine());
//     if (max1 < n)
//     {
//         max2 = max1;
//         max1 = n;
//     }
//     else if (max2 < n)
//     {
//         max2 = n;
//     }
// }
// Console.WriteLine(max2);