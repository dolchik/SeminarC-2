//Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.

Console.Clear();

int randomN = new Random().Next(100, 1000); //переменная со случайным числом от 100 до 999

// Длинное решение!
// Console.WriteLine($"Случайное число: {randomN}");

// int ostatok = randomN % 10;
// Console.WriteLine($"Последняя цифра: + {ostatok}");

// int first = randomN / 100;
// Console.WriteLine($"Первая цифра: + {first}");

// Console.WriteLine($"Первая и последня цифры: {first}{ostatok}");

// Короткое решение

int result = (randomN / 100) * 10 + randomN % 10;
Console.WriteLine(randomN + " -> " + result);
