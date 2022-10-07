// Задача№10 Напишите программу которая на вход принимает трехзначное число
// и на выходе показывает вторую цифру этого числа
/*
int a;
Console.WriteLine("Введите любое трехзначное число:");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine($"{"Вторая цифра данного числа = "}{a / 10 % 10}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

// Решение№1
/*
int a;
Console.WriteLine("Введите любое число:");
int.TryParse(Console.ReadLine(), out a);
int temp = a;
int index = 0;
while (temp > 0)
{
    temp /= 10;
    index++;
}
if (index > 2)
    Console.WriteLine($"Третья цифра данного числа = {(a / (int)Math.Pow(10, index - 3)) % 10}");
else
    Console.WriteLine("Третьей цифры в данном числе не существует");
*/

// Решение №2
/*
int a;
Console.WriteLine("Введите любое число:");
int.TryParse(Console.ReadLine(), out a);

if (Math.Abs(a) < 100)
    Console.WriteLine($"Третьей цифры в данном числе не существует");
else
{
    int temp = a;
    while (Math.Abs(temp) >= 1000)
        temp /= 10;
    Console.WriteLine($"Третья цифра данного числа = {temp % 10}");
}
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */


int a;
Console.WriteLine("Введите число, которое обозначает день недели (1-7):");
int.TryParse(Console.ReadLine(), out a);
if (a == 6 || a == 7)
    Console.WriteLine("Данный день недели является выходным");
else
    Console.WriteLine("Данный день недели является рабочим");