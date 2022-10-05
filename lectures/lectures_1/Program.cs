//Задача_1 на сложение двух рандомных чисел от 1 до 9 включительно с выводом на экран
/*
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
*/

//Задача_2, приветствие любимчика
/*
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
*/

//Задача_3 про гири из прошлой темы

int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 40;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);