Console.Clear();
int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
ArithmeticMean(array);

void ArithmeticMean(int[,] array)
{
    Console.WriteLine("Ваше среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0):f2} | ");
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Количество значений в каждом столбце: {array.GetLength(0)}");
}
