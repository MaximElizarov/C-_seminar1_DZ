Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Большее число: ");

if (a > b)
    Console.Write(a);    
else
    Console.Write(b);    

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3