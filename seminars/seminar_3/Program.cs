//Ищем в какой четверти находится точка, в системе координат x;y
/*
int x = 0, y = 0;
Console.Write($"Введите координату X: ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write($"Введите координату Y: ");
int.TryParse(Console.ReadLine()!, out y);

if (x > 0)
{
    if (y > 0)
        Console.Write("Плоскость 1");
    else if (y < 0)
        Console.Write("Плоскость 4");
    else
        Console.Write("Точка лежит на оси X");
}
else if (x < 0)
{
    if (y > 0)
        Console.Write("Плоскость 2");
    else if (y < 0)
        Console.Write("Плоскость 3");
    else
        Console.Write("Точка лежит на оси X");
}
else
{
    if (y == 0)
        Console.Write("Точка лежит на начале коррдинат");
    else
        Console.Write("Точка лежит на оси Y");
}
*/

//Ищем расстояние между двумя точками, в системе координат x;y, с помощью теоремы Пифагора
/*
int[] A = new int[2];
int[] B = new int[2];
Console.Write($"Введите координату X первой точки: ");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write($"Введите координату Y первой точки: ");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write($"Введите координату X второй точки: ");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write($"Введите координату Y второй точки: ");
int.TryParse(Console.ReadLine()!, out B[1]);

double c = Math.Sqrt(Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2));

Console.Write($"Расстояние между точками = {c}");
*/

/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
/*
int a = 0;
Console.Write($"Введите координатную четверть: ");
int.TryParse(Console.ReadLine()!, out a);

switch (a)
{
    case 1:
        Console.Write($"X > 0  Y > 0");
        break;
    case 2:
        Console.Write($"X < 0  Y > 0");
        break;
    case 3:
        Console.Write($"X < 0  Y < 0");
        break;
    case 4:
        Console.Write($"X > 0  Y < 0");
        break;
    default:
        Console.Write($"Неверный ввод!");
        break;
}
*/

/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

int a = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

for (int i = 0; i <= a; i++)
    Console.Write($"{i * i} ");
