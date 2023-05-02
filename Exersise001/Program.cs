double GetRandomValue()
{
    int minCounter = -9;
    int maxCounter = 9;
    return Math.Round(new Random().NextDouble() * 
        new Random().Next(minCounter, maxCounter + 1), 1);
}

double[,] GetRandomArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = GetRandomValue();
        }
    }

    return array;
}

void PrintArray(double[,] array)
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

Console.Write("Enter the amountof rows in array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the amountof columns in array: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = GetRandomArray(rows, columns);
PrintArray(array);