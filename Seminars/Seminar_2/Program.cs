// https://gb.ru/lessons/281090
// Урок 2. Базовые алгоритмы

Console.Clear();

//int n = new Random().Next(10, 100); // [begin, end + 1] [10, 99]
//Console.WriteLine($"Случаное число {n}");
//int n1 = n / 10; // кол-во десятков
//int n2 = n % 10; // кол-во единиц
//if (n1 > n2)
//    Console.WriteLine(n1);
//else
//    Console.WriteLine(n2);


//int n = new Random().Next(100, 1000); // [begin, end + 1] [10, 99]
//Console.WriteLine($"Случаное число {n}");
//int n1 = n / 100; // кол-во десятков
//int n3 = n % 10; // кол-во едини
//Console.WriteLine( n1 * 10 + n3 );


//string? s = Console.ReadLine();
//Console.WriteLine(Convert.ToInt32(s[0].ToString()));


//Console.Clear();
//string? s = Console.ReadLine();
//Console.WriteLine(Convert.ToInt32(s[0].ToString()) * 5);

//Проверка введенных чисел на кратность
//Console.Write("Введите 1-ое число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 2-ое число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//if (n % m == 0)
//    Console.WriteLine("Кратно");
//else
//    Console.WriteLine($"Не кратно, остаток {n % m}");


// task 14-1
//Console.Clear();
//Console.Write("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n % 7 == 0 && n % 23 == 0) // & - и, | - или
//    Console.WriteLine("yes");
//else
//    Console.WriteLine("no");

// task 14-2
//Console.Clear();
//Console.Write("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n % 7 == 0)
//{
//    if (n % 23 == 0)
//        Console.WriteLine("yes");
//    else
//        Console.WriteLine("no");
//}
//else
//    Console.WriteLine("no");


// task 16-1
//Console.Clear();
//Console.Write("Введите 1-ое число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 2-ое число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//if (n * n == m)
//    Console.WriteLine("yes");
//else if (m * m == n)
//    Console.WriteLine("yes");
//else
//    Console.WriteLine("no");


// task 16
//Console.Clear();
//Console.Write("Введите 1-ое число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 2-ое число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//if (n * n == m || m * m == n)
//    Console.WriteLine("yes");
//else
//    Console.WriteLine("no");