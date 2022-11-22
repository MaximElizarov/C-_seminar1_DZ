Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
int i = 2;
while (i <= n)
{
    Console.Write($"{i} ");
    i = i + 2; 
}



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8