// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void InputMatrix(int[,,] matrix) // Генерация трехмерного массива
{
    int n = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for ( int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = n;
                Console.Write($"{matrix[i, j, k]} {(i,j,k)}\t");
                n = n + 1;
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива (число строк и столбцов): ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
while (size[0] * size[1] * size[2] > 99)
{
   Console.Write("Ошибка, повторите ввод: ");
   size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
   matrix = new int[size[0], size[1], size[2]];
}
Console.WriteLine("______________________________________________________");
InputMatrix(matrix);

// ****************************************************************************
// Решение преподователя

// void InputMatrix(int[,,] ThreeMatrix)
// {
//     int number = 10;
//     for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
//                 ThreeMatrix[i, j, k] = number++; 
//         }
//     }
// }


// void PrintMatrix(int[,,] ThreeMatrix)
// {
//     for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
//                 Console.WriteLine($"{ThreeMatrix[i, j, k]} ({i}, {j}, {k})");
//         }
//     }
// }


// Console.Clear();
// Console.Write("Введите размер трехмерного массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// while (size[0] * size[1] * size[2] > 90)
// {
//     Console.Write("Значения введены некорректные!\nВведите размер трехмерного массива: ");
//     size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// int[,,] ThreeMatrix = new int[size[0], size[1], size[2]];
// InputMatrix(ThreeMatrix);
// PrintMatrix(ThreeMatrix);