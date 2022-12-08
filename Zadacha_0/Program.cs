Console.Clear();

int randomN = new Random().Next(10, 100); // случайное число от 10 до 99
Console.WriteLine("Случайное число: " + randomN);

int ostatok = randomN%10;
Console.WriteLine("Последняя цифра: " + ostatok);

int first = randomN / 10;
Console.WriteLine("Первая цифра: " + first);

int max = first;

if (ostatok > first) max = ostatok;
Console.WriteLine("Максимум: " + max);