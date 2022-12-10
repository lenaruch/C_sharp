// 12. Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();
// string? s = Console.ReadLine();
// Console.WriteLine(Convert.ToInt32(s[0].ToString()) * 5);

//Проверка введенных чисел на кратность
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0)
   Console.WriteLine("Кратно");
else
   Console.WriteLine($"Не кратно, остаток {n % m}");