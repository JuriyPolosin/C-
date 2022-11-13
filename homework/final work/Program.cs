
string[] array = { "hello", "2", "world", ":-)" };

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write($"{array[i]} ");
    }
}