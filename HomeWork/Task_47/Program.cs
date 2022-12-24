// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void InputMatrix(double[,] matrix) // функция для создания двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (50 - 10) - 10, 2); // [-10, 50]
            Console.Write($"{matrix[i, j]} \t"); // \t - добавляет Тав между элементами массива для красоты отображения
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // ввод в одну строку, разделитель пробел
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);