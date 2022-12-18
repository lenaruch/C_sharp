// https://gbcdn.mrgcdn.ru/uploads/record/229133/attachment/113bf52288bf20c4cc0fd9116fc46f29.mp4
// Урок 6. Одномерные массивы. Продолжение
// Гипотеза Гольдбаха
// int n = Convert.ToInt32(Console.ReadLine());
// int countDel = 0, i, j, k, m;
// for (i = 2; i <= n / 2; i++)
// {
//     countDel = 0;
//     for (j = 2; j <= i / 2; j++)
//     {
//         if (i % j == 0)
//             countDel++;
//     }
//     if (countDel == 0)
//     {
//         countDel = 0;
//         m = n - i;
//         for (k = 2; k <= (m + 1) / 2; k++)
//         {
//             if (m % k == 0)
//                 countDel++;
//         }
//         if (countDel == 0)
//         {
//             Console.WriteLine($"{i} {m}");
//             return;
//         }
//     }
// }

// *******************************************************************************

// Функция сплит

// string[] s = Console.ReadLine().Split("а");
// for (int i = 0; i < s.Length; i++)
//     Console.WriteLine(s[i]);

// int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// foreach (int element in s)
//     Console.WriteLine(element * 2);

// *******************************************************************************
// ДЗ суперсдвиг

// int n = Convert.ToInt32(Console.ReadLine());
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int k = Convert.ToInt32(Console.ReadLine());
// int[] result = new int[numbers.Length];
// k %= n;
// if (k > 0)
// {
//     for (int i = 0; i < k; i++)
//         result[i] = numbers[numbers.Length - k + i];
//     for (int i = 0; i < numbers.Length - k; i++)
//         result[k + i] = numbers[i];
//     Console.WriteLine($"{string.Join(" ", result)}");
// }
// else
// {
//     k = k * (-1);
//     for (int i = 0; i < k; i++)
//         result[numbers.Length - k + i] = numbers[i];
//     for (int i = 0; i < numbers.Length - k; i++)
//         result[i] = numbers[k + i];
//     Console.WriteLine($"{string.Join(" ", result)}");
// }

// *******************************************************************************
// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11); // [1, 10]
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// *******************************************************************************

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// Console.Clear();
// Console.Write("Введите 3 числа: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// if (a < b + c && b < a + c && c < a + b)
//     Console.WriteLine("Треугольник");
// else
//     Console.WriteLine("Нет");
// *******************************************************************************

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string result = string.Empty;
// while (n > 0)
// {
// result = result + Convert.ToString(n % 2); 
// данный результат нужно развернуть в обратную сторону...для этого нужно поменять местами слагаемые
// n /= 2; // n = n / 2;
// }
// Console.WriteLine(result);

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string result = string.Empty;
// while (n > 0)
// {
// result = Convert.ToString(n % 2) + result;
// n /= 2; // n = n / 2;
// }
// Console.WriteLine(result);

// *******************************************************************************

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), a0 = 0, a1 = 1;
// for (int i = 0; i < n; i++)
// {
// Console.Write($"{a0} ");
// int x = a0 + a1;
// a0 = a1;
// a1 = x;
// }

// *******************************************************************************

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] a = {1, 2, 3, 4, 5};
// int[] b = new int[a.Length];
// for (int i = 0; i < a.Length; i++)
// b[i] = a[i];

// b[0] = -1;
// Console.WriteLine(string.Join(" ", a));
// Console.WriteLine(string.Join(" ", b));

// *******************************************************************************

