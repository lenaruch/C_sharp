// https://gbcdn.mrgcdn.ru/uploads/record/226882/attachment/efe24cc1b6627c472fe0abe523a44d23.mp4
// Урок 3. Базовые алгоритмы. Продолжение

Console.Clear();

//string? n = Console.ReadLine(); // null-значение
//Console.WriteLine(Convert.ToInt32(n[0].ToString()) * 5); // char != string

//Task 17
// Console.Clear();
// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());

// while (x == 0)
// {
//     Console.Write("Вы ошиблись!\nВведите координату X: ");
//     x = Convert.ToDouble(Console.ReadLine());
// }
// while (y == 0)
// {
//     Console.Write("Вы ошиблись!\nВведите координату Y: ");
//     y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");


// Task 18 
// Программа по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти(х и у)

// Console.Write("Введите номер четверти: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n == 1 || n == 2)
//     Console.WriteLine("y > 0");
// else
//     Console.WriteLine("y < 0");

// if (n == 1 || n == 4)
//     Console.WriteLine("x > 0");
// else
//     Console.WriteLine("x < 0");



// Console.Clear();
// double result = Math.Sqrt(25);
// Console.WriteLine(result);


// task 20 расстояние между двумя точками на оси кординат

// Console.Clear();
// Console.Write("Введите X первой точки: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y первой точки: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите X второй точки: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y второй точки: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

// Console.WriteLine(Math.Round(dist, 2));


// task 22

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{i * i} ");