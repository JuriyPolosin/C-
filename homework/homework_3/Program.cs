//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
int a;
Console.WriteLine("Введите любое пятизначное число:");
int.TryParse(Console.ReadLine(), out a);
string str = a.ToString();
    if (str[0] == str[4] && str[1] == str[3])
        Console.WriteLine($"Число является палиндромом");
    else
        Console.WriteLine($"Число не является палиндромом");
*/
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
int[] A = new int[] { 5, 7, 9 };
int[] B = new int[] { 51, 77, 96 };

int X = (int)Math.Pow(A[0] - B[0], 2);
int Y = (int)Math.Pow(A[1] - B[1], 2);
int Z = (int)Math.Pow(A[2] - B[2], 2);

double Ans = Math.Sqrt(X + Y + Z);

Console.WriteLine(Ans); */

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int a;
Console.WriteLine("Введите любое число:");
int.TryParse(Console.ReadLine(), out a);
for (int i = 1; i <= a; i++)
    Console.Write($"{i * i * i} ");
