//Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
int a, b;
Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine(), out b);

int pow(int a, int b)
{
    int ans = a;
    for (int i = 1; i < b; i++)
        ans *= a;
    return ans;
}

Console.Write($"{pow(a, b)}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*
int a;
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out a);

int pow(int a)
{
    int ans = 0;
    int temp = a;
    while (temp > 0)
    {
        ans += temp % 10;
        temp /= 10;
    }
    return ans;
}
Console.Write($"{pow(a)}");
*/

//Задача 29: Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = CreateArray();

int[] CreateArray()
{
    int[] _array = new int[8];
    int a;
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Введите элемент[{i}]: ");
        int.TryParse(Console.ReadLine()!, out a);
        _array[i] = a;
    }
    foreach (var item in _array)
        Console.Write($"{item} ");
    return _array;
}