// Напишите программу, которая 
// 1принимает на вход трёхзначное число и 
// 2на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
    return;
}

Console.WriteLine($"Введенное число: {number}");
int secondDigit = number / 10 % 10;
Console.WriteLine($"Вторая цифра: {secondDigit}");