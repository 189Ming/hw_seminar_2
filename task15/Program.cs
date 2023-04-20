// Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.



Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit > 5 && digit < 8)
{
    Console.WriteLine("сегодня выходной");
}
else if (digit > 0 && digit < 6)
{
    Console.WriteLine("сегодня будний день");
}