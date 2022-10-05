//Задача на сложение двух рандомных чисел от 1 до 9 включительно с выводом на экран
/*
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
*/

//Задача, приветствие любимчика

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