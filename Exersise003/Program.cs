int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

int[,] GetArray()
{
    int[,] array = new int[GetRandomValue(3, 6), GetRandomValue(3, 6)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = GetRandomValue(0, 9);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }

        Console.WriteLine();
    }
}

double[] GetAverageByColumns(int[,] array)
{
    double[] result = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double temp = 0;

        for (int j = 0; j < array.GetLength(0); j++)
        {
            temp += array[j, i];
        }

        result[i] = Math.Round(temp / array.GetLength(0), 1);
    }

    return result;
}

int[,] array = GetArray();
PrintArray(array);
Console.WriteLine("Average by columns:");

foreach (var value in GetAverageByColumns(array))
{
    Console.Write(value + " ");
}