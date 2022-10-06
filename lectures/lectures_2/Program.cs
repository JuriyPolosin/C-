// Находим максимум из чисел
/*
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 43;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
*/
// Находим максимум из чисел с помощью функций
/*
internal class Program
{
    private static void Main(string[] args)
    {
        int Max(int arg1, int arg2, int arg3)
        {
            int result = arg1;
            if (arg2 > result) result = arg2;
            if (arg3 > result) result = arg3;
            return result;
        }

        int a1 = 15;
        int b1 = 2111;
        int c1 = 39;
        int a2 = 12;
        int b2 = 43;
        int c2 = 33;
        int a3 = 13;
        int b3 = 23;
        int c3 = 333;
        
        int max = Max(
            Max(a1, b1, c1),
            Max(a2, b2, c2),
            Max(a3, b3, c3));

        Console.WriteLine(max);
    }
}
*/
//Ищем индекс искомой цифры
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//             0  1   2  3  4  5  6  7  8
int[] array = { 11, 21, 19, 41, 51, 61, 71, 81, 19 };
int n = array.Length;
int find = 19;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        //break;
    }
    index++;
}
*/
// Заполнение массива и вывод его на экран
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
