//к сожалению запутался в этом задании.


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// (ввод пользователя с клавиатуры).
// Например: 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Clear();
Console.Write("Введите элементы массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
for (int i = 0; i < array.Length; i++)
    array[i] = new 
    Console.WriteLine($"Результат: [{string.Join(" ", array)}]");