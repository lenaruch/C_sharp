// Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
//После записи элементов в массив, необходимо его вывести на экран.
// 8
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int ElementsCount = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[ElementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Вы ввели массив: [{string.Join(", ", myArray)}]");