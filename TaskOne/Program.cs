// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = CreateArray(10);
int valueEven = CountEvenNumbers(array);
Console.WriteLine($"Массив трехзначных чисел: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел в массиве: {valueEven}");

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] CreateArray(int countElements)
{
    int []array = new int[countElements];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}
