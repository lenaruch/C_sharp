// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix(int[,] matrix) // Генерация двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // Случайные числа в промежутке от [1, 10]
    }
}


void PrintMatrix(int[,] matrix) // Вывод матрицы на экран после преобразования
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


int[,] ReleaseMatrix(int[,] Matrix1, int[,] Matrix2) // Умножение матриц
{
    int[,] result = new int[Matrix1.GetLength(0), Matrix1.GetLength(1)];
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix1.GetLength(1); j++)
            result[i, j] = Matrix1[i, j] * Matrix2[i, j];
    }
    return result;
}


Console.Clear();
Console.Write("Введите размер матриц: "); // размеры матриц должны быть одинаковые
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] Matrix1 = new int[size[0], size[1]];
int[,] Matrix2 = new int[size[0], size[1]];
InputMatrix(Matrix1);
InputMatrix(Matrix2);
Console.WriteLine("Начальный массив 1: ");
PrintMatrix(Matrix1);
Console.WriteLine("Начальный массив 2: ");
PrintMatrix(Matrix2);
Console.WriteLine("Результат:");
PrintMatrix(ReleaseMatrix(Matrix1, Matrix2));