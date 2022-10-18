//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int M;
Console.WriteLine("Задайте размера нашего списка:");
int.TryParse(Console.ReadLine()!, out M);

int k = 0;

for (int i = 0; i < M; i++)
{
    int a;
    Console.Write("Введите значения элементов списка:");
    int.TryParse(Console.ReadLine()!, out a);
    if (a > 0)
        k++;
}

Console.WriteLine($"В данном списке элементов > 0 -> {k}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1, b2, k1, k2;
Console.WriteLine("Введите значение k1:");
int.TryParse(Console.ReadLine(), out k1);
Console.WriteLine("Введите значение b1:");
int.TryParse(Console.ReadLine(), out b1);
Console.WriteLine("Введите значение k2:");
int.TryParse(Console.ReadLine(), out k2);
Console.WriteLine("Введите значение b2:");
int.TryParse(Console.ReadLine(), out b2);

double x = (double)(b2 - b1) / (k1 - k2);
double y = (double)k1 * x + b1;

Console.WriteLine($"Наши прямые пересекаются в точке с координатами: (x = {x}; y = {y})");