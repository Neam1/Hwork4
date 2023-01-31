//task 25
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// Math.Pow(ЗАПРЕЩЕНО)
// Например: 3, 5 -> 243 (3⁵)
// Например: 2, 4 -> 16
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i <= b; i++)
    result = result * a; 
Console.WriteLine($"Первое число в степени второго числа: {result}");