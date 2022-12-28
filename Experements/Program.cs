// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
        
    }
}

void SumStringMatrix(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) // суммирование элементов каждой сторки
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}"); // вывод суммы с указанием номера строки
        
        if (i == 0) 
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов это: {index+1}");
} 

Console.Clear();
Console.Write("Введите размер массива (число строк и столбцов): ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
Console.WriteLine("Сумма элементов каждой из сторк:");
SumStringMatrix(matrix);
