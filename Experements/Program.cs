
Console.Clear();
Console.Write("Введите размеры матриц: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] m = new int[size[0], size[1]];
int[,] n = new int[size[0], size[1]];
int[,] p = new int[size[0], size[1]];
Console.WriteLine($"Первая матрица:");
CreateArray(firstMartrix);
Console.WriteLine($"Вторая матрица:");
CreateArray(secomdMartrix);
Console.WriteLine($"Результат:");
//MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


void CreateArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
