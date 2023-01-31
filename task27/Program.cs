// task27
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Например: 452 -> 11
// Например: 82 -> 10
// Например: 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()), result = 0;
while (a > 0)
{
    result = result + a % 10;
    a = a / 10;
}
Console.WriteLine($"Cумма цифр в числе: {result}");