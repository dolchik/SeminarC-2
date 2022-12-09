// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
int doubleFirst = first * first;
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
int doubleSecond = second * second;

if ((doubleFirst == second) || (doubleSecond == first))
    Console.WriteLine($"{first},{second} -> да");
else
    Console.WriteLine($"{first}, {second} -> нет");