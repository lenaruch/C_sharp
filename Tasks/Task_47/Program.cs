// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет (пользователь вводит нумерацию с 1)

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

Console.Clear();
int[,] matrix = new int[5, 5];
InputMatrix(matrix);
Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x < 1 || x > 5)
{
   Console.Write("Такой сторки нет, повторите ввод cтроки: ");
   x = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите номер столбца: ");

int y = Convert.ToInt32(Console.ReadLine());
while (y < 1 || y > 5)
{
   Console.Write("Такой столбца нет, повторите ввод cтолбца: ");
   y = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(matrix[x-1, y-1]);