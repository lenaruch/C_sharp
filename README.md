# **Знакомство с языком программирования С#**

### **Структура репозитория**

* *Task_n* - Задача "n" (Отсортированные и упорядоченные)
* *Lecture_n* - Лекции по C# (код программы и примеры)
* *Seminar_n* - Запись кода программы из семинара
* *HomeWork* - Домашняя работа по С# 
* *HomeWork_Hard* - Домашняя работа повышенной сложности

# **Задачи:**

1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
   
        a = 5; b = 25 -> да 
    
        a = 2 b = 10 -> нет 
    
        a = 9; b = -3 -> нет 
    
        a = -3 b = 9 -> да

2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

        a = 5; b = 7 -> max = 7

        a = 2 b = 10 -> max = 10

        a = -9 b = -3 -> max = -3

3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

        3 -> Среда 

        5 -> Пятница

4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

        2, 3, 7 -> 7

        44 5 78 -> 78

        22 3 9 -> 22

5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

        4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 

        2 -> " -2, -1, 0, 1, 2"

6. Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

        4 -> да

        -3 -> нет

        7 -> нет

7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
    
        456 -> 6	
    
        782 -> 2
    
        918 -> 8

8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

        5 -> 2, 4

        8 -> 2, 4, 6, 8

9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
    
        78 -> 8 

        12-> 2 
    
        85 -> 8 

10.   Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

            456 -> 5

            782 -> 8

            918 -> 1

11.  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

            456 -> 46

            782 -> 72

            918 -> 98

12.  Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.

            34, 5 -> не кратно, остаток 4 

            16, 4 -> кратно

13.  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
**НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК!!!**
    
            645 -> 5
    
            78 -> третьей цифры нет
    
            32679 -> 6

14.  Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

            14 -> нет 

            46 -> нет 
    
            161 -> да

15.  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    
            6 -> да
    
            7 -> да
    
            1 -> нет

16.  Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

            5, 25  ->  да

            -4, 16  ->  да

            25, 5  ->  да

            8,9  ->  нет

17.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
    
18.  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

19.  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    
            14212 -> нет
    
            12821 -> да
    
            23432 -> да

20.  Напишите программу, которая принимает на вход координаты двух точек  и находит расстояние между ними в 2D пространстве.
    
            A (3,6); B (2,1) -> 5,09 
    
            A (7,-5); B (1,-1) -> 7,21

21.  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    
            A (3,6,8); B (2,1,-7), -> 15.84
    
            A (7,-5, 0); B (1,-1,9) -> 11.53

22.  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
    
            5 -> 1, 4, 9, 16, 25.
    
            2 -> 1,4

23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    
            3 -> 1, 8, 27
    
            5 -> 1, 8, 27, 64, 125

24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

        7 -> 28

        4 -> 10

        8 -> 36

25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. **Нельзя использовать функцию Math.Pow**
    
            3, 5 -> 243 (3⁵)
    
            2, 4 -> 16

26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

        456 -> 3

        78 -> 2

        89126 -> 5

27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

            452 -> 11

            82 -> 10

            9012 -> 12

28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

        4 -> 24 

        5 -> 120

29. Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. После записи элементов в массив, необходимо его вывести на экран.
    
        8
    
        1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

        [1,0,1,1,0,1,0,0]

31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

        Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

        [-4, -8, 8, 2] -> [4, 8, -8, -2] 

33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

        4; массив [6, 7, 19, 345, 3] -> нет

        -3; массив [6, 7, 19, 345, 3] -> да

34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    
        [345, 897, 568, 234] -> 2

35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

        Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

        [5, 18, 123, 6, 2] -> 1

        [1, 2, 3, 6, 2] -> 0

        [10, 11, 12, 13, 14] -> 5

36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    
        [3, 7, 23, 12] -> 19
    
        [-4, -6, 89, 6] -> 0

37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    
        [3 7 22 2 78] -> 76

39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

        [1 2 3 4 5] -> [5 4 3 2 1]

        [6 7 3 6] -> [6 3 7 6]

40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

        Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

        0, 7, 8, -2, -2 -> 2

        -1, -7, 567, 89, 223-> 3

42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

        45 -> 101101

        3  -> 11

        2  -> 10

43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

        b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

        Если N = 5 -> 0 1 1 2 3

        Если N = 3 -> 0 1 1

        Если N = 7 -> 0 1 1 2 3 5 8

45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

46. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

        m = 3, n = 4.

        1 4 8 19

        5 -2 33 -2

        77 3 8 1

47. c

48. c

49. c

50. c

51. c

52. c

53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

54. c

55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

56. c

57. c

58. c

59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

        Например, задан массив:
        
        1 4 7 2
        5 9 2 3
        8 4 2 4
        5 2 6 7
        
        Наименьший элемент - 1, на выходе получим 
        следующий массив:
        
        9 4 2
        2 2 6
        3 4 7

60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    
        Массив размером 2 x 2 x 2
    
        66(0,0,0) 25(0,1,0)
    
        34(1,0,0) 41(1,1,0)
    
        27(0,0,1) 90(0,1,1)
    
        26(1,0,1) 55(1,1,1)

61.  Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

62.  Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:
        
            01 02 03 04
    
            12 13 14 05
    
            11 16 15 06    
    
            10 09 08 07

63.  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

            N = 5 -> "1, 2, 3, 4, 5"

            N = 6 -> "1, 2, 3, 4, 5, 6"

64.  c

65.  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

            M = 1; N = 5 -> "1, 2, 3, 4, 5"

            M = 4; N = 8 -> "4, 6, 7, 8"

66.  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30

67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

        453 -> 12

        45 -> 9

68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    
        m = 2, n = 3 -> A(m,n) = 9        
    
        m = 3, n = 2 -> A(m,n) = 29

69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

        A = 3; B = 5 -> 243 (3⁵)

        A = 2; B = 3 -> 8