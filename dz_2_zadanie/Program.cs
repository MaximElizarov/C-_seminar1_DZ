Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Большее число: ");
if (a >= b & a >= c)
    Console.Write(a);
else if (b >= a & b >= c )
    Console.Write(b);
else if (c >= a & c >= b)
    Console.Write(c);

// Задача 4: Напишите программу, которая принимает на входдаёт максимальное из три числа и вы этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22