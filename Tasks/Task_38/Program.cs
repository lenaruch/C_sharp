// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void findMaxMin(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i] > max)
                max = array[i];
    }
    Console.WriteLine($"Max = {max}");

    double min = max;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i] < min)
                min = array[i];
    }
    Console.WriteLine($"Min = {min}");
    Console.WriteLine($"Разница {max - min}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
    //                                              * (end - begin) + begin
    array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2); // [10, 50]
}
Console.WriteLine($"[{string.Join(", ", array)}]");

findMaxMin(array);
