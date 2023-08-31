// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double [] array = CreateArray(5);
System.Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Difference(array);
void Difference(double [] array){
    double maxValue = double.MinValue;
    double minValue = double.MaxValue;
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue){
            maxValue = array[i];
        }
        if (array[i] < minValue){
            minValue = array[i];
        }
    }
    result = maxValue - minValue;
    System.Console.WriteLine($"{maxValue} - {minValue} = {result}");
}
double [] CreateArray(int countElements)
{
    double []array = new double [countElements];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(1 + random.NextDouble() * 100-1, 2);
    }
    return array;
}
