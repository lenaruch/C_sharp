// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999); // [100, 999]
}


void ReleaseArray(int[] array)
{
    int sumEven = 0, sumOdd = 0; // Even - четное; Odd - нечетное (перевод с англ.)
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
            sumEven = sumEven + 1;
        else
            sumOdd = sumOdd + 1;
    }
    Console.WriteLine($"Количество четных чисел равна {sumEven}");
    Console.WriteLine($"Количество нечетных чисел равна {sumOdd}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);