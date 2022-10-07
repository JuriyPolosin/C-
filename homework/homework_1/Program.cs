// Задача №2 Напишите программу, которая на вход принимает два числа и выдает
// какое число большее, а какое меньшее
/*
int a, b;
Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine(), out b);
if (a > b)
    Console.WriteLine($"Максимальное число, а = {a}");
else if (b > a)
    Console.WriteLine($"Максимальное число, b = {b}");
else
    Console.WriteLine("Числа a и b равны");
*/

// Задача №4 Напишите программу, которая на вход принимает три числа и выдает максимальное 
/*
int a, b, c;

Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine(), out b);
Console.WriteLine("Введите третье число");
int.TryParse(Console.ReadLine(), out c);

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное число = {max}");
*/

// Задача№6 Напишите программу, которая на вход принимает число и выдает является ли оно четным
/*
int a;
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out a);

if (a % 2 == 0)
    Console.WriteLine("Число четное");
else
    Console.WriteLine("Число не четное");
*/

// Задача №8 Напишите программу которая на вход принимает число N, а на выходе показывает все четные
// числа от 1 до N
/*
int a;
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out a);

for (int i = 2; i <= a; i = i + 2)
    Console.Write($"{i}");
*/