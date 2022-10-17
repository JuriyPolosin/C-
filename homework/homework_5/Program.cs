//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int[] array = new int[new Random().Next(6, 10)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
}

int A = 0;

foreach (var item in array)
    if (item % 2 == 0)
        A++;

Console.Write($"-->{A}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int[] array = new int[new Random().Next(6, 10)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}

int A = 0;

for (int i = 1; i < array.Length; i += 2)
    A += array[i];

Console.Write($"--> {A}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] array = new double[new Random().Next(6, 10)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = (double)new Random().Next(0, 10 * 10) / 10;
    Console.Write($"{array[i]}  ");
}

double min = array[0];
double max = array[0];

foreach (var item in array)
{
    if (min > item)
        min = item;
    if (max < item)
        max = item;
}

Console.Write($"\nmin = {min} max = {max} (max - min) = {max - min}");

