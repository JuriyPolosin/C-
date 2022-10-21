/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
/*
const int a = 3, b = 4;
int[,] array = new int[a, b];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int k = 0; k < array.GetLength(1) - 1; k++)
    {
        int count = 0;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                count++;
                int temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }
        if (count == 0)
            break;
    }
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
    Console.WriteLine();
}
*/


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
const int a = 4, b = 4;
int[,] array = new int[a, b];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int k = 0, sum = 0;
for (int j = 0; j < array.GetLength(1); j++)
    sum += array[0, j];
for (int i = 1; i < array.GetLength(0); i++)
{
    int tsum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        tsum += array[i, j];
    if (tsum < sum)
    {
        sum = tsum;
        k = i;
    }
}
Console.Write($"строка {k}, sum = {sum}");
*/


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] A = new int[3, 3]
{
    {2, 4, 1},
    {3, 2, 3},
    {3, 2, 4}
};
int[,] B = new int[3, 3]
{
    {3, 4, 2},
    {2, 4, 1},
    {3, 3, 5}
};

if (A.GetLength(1) != B.GetLength(0))
{
    Console.Write($"Вычислить произведение данных матриц не возможно из-за не соответствия размеров");
    return;
}

int[,] C = new int[A.GetLength(0), B.GetLength(1)];

for (int i = 0; i < C.GetLength(0); i++)
{
    for (int j = 0; j < C.GetLength(1); j++)
    {
        for (int k = 0; k < A.GetLength(1); k++)
        {
            C[i, j] += A[i, k] * B[k, j];
        }
    }
}

for (int i = 0; i < C.GetLength(0); i++)
{
    for (int j = 0; j < C.GetLength(1); j++)
        Console.Write($"{C[i, j]} ");
    Console.WriteLine();
}
*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
/*
int[,,] array = new int[5, 5, 4];

List<int> nums = new List<int>();

for (int i = 0; i < 90; i++)
    nums.Add(i + 10);


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            if (nums.Count == 0)
                array[i, j, k] = 0;
            else
            {
                int temp = new Random().Next(nums.Count);
                array[i, j, k] = nums[temp];
                nums.RemoveAt(temp);
            }
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i, j, k]} ");
        }
    }
}
*/



/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] array = new int[5, 5];

for (int i = 0, j = 0, t = 0; t < array.Length; t++)
{
    array[i, j] = t + 1;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(string.Format("{0:D2} ", array[i, j]));
    Console.WriteLine();
}


