// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int ElementsCount = Convert.ToInt32(Console.ReadLine());
// int[] myArray = new int[ElementsCount];
// int count = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         count = count + 1;
// }

// Console.WriteLine(count);

// Вариант, где пользователя не спрашивают количество элементов
// а сразу указывают, что нужно указать данные через пробел

Console.Clear();
Console.Write("Введите числа через пробел: ");
int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i] > 0)
        count = count + 1;
}

Console.WriteLine($"Введено положительных чисел: {count}");