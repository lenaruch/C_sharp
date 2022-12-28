// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void InputMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void BubbleSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        int minPosition = i;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if(array[l] < array[minPosition]) minPosition = l;
            {
            minPosition = l;
            }
        }
        int temporary = array[j];
        array[j] = array[minPosition];
        array[minPosition] = temporary;
        }
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];
Console.WriteLine("Массив до сортировки:");
InputMatrix(array);
Console.WriteLine("___________________________");
Console.WriteLine("Массив после сортировки: ");
// BubbleSort(array);
Array.Sort(array);
foreach 
