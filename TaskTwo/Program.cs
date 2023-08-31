using System;
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int [] array = CreateArray(10);
int sumElements = SumOddElements(array);
System.Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
System.Console.WriteLine($"Сумма нечетных элементов в массиве: {sumElements}");
int[] CreateArray(int countElements)
{
    int []array = new int[countElements];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 101);
    }
    return array;
}
int SumOddElements(int [] array){
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0){
            result += array[i];
        }
    }
    return result;
}



