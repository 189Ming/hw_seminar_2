// Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

int ThirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
Console.Write("Третье число: ");
Console.Write(ThirdDigit(number));