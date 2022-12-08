// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()); // парсим ответ
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
int ostatok = first % second;               // переменная с остатком от деления

if (first % second ==0)
    Console.WriteLine($"{first}, {second} -> кратно");
else 
    Console.WriteLine($"не кратно, остаток {ostatok}");
