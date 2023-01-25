Console.Clear();
Console.Write("Из какой строки (1-5) вам нужно значение?  ");
int row = int.Parse(Console.ReadLine());

Console.Write("Из какого столбца (1-5) вам нужно значение?  ");
int column = int.Parse(Console.ReadLine());

double[,] array = GetArray(5, 5, -10, 10);
Console.WriteLine();
Console.WriteLine("Ваш случайный массив: ");
PrintArray(array);
Console.WriteLine();
DesiredValue(array);
void DesiredValue(double[,] inArray)
{
    if (row > inArray.GetLength(0) || column > inArray.GetLength(1))
    {
        Console.WriteLine($"За пределами размера массива. Попробуй еще раз!");
    }
    else
    {
        Console.Write($"Ваше желаемое значение {array[row - 1, column - 1]:f2}");
    }
}


void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
}
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
            if (result[i, j] > maxValue) result[i, j] = maxValue;
        }
    }
    return result;
} 