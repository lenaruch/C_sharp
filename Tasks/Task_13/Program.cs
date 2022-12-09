// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear(); 

//Решение переводом в строку и выводом 2 индекса 
//int n = new Random().Next();
//Console.WriteLine($"Случаное число {n}");
//string str = n.ToString();

//if ( n > 100)
//    Console.WriteLine( $"Третья цифра этого числа: {str[2]}");
//else
//    Console.WriteLine("Нет третьей цифры");


//Решение, где {a} находится в промежутке между 100 и 1000
//    int a = new Random().Next(100, 1000);
//    Console.WriteLine($"Случаное число {a}");
//    if ( a < 100 )
//        Console.WriteLine("Третьего числа нет");
//    else Console.WriteLine(a=a%10);


//Решение через деление
int a = new Random().Next();
Console.WriteLine($"Случаное число {a}");

if ( a > 99 )
{
    while (a > 999)
    {
        a=a/10;
    }
    Console.WriteLine($"Третье цифра этого числа: {a%10}");
}
else Console.WriteLine("Третьего числа нет");