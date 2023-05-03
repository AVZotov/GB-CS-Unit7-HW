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

bool FindValue(int[,] array, int value)
{
    bool result = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == value)
                result = true;
        }
    }

    return result;
}

Console.Write("Enter the number you want to find in 2 dimension array: ");
int userValue = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray();
PrintArray(array);

if (FindValue(array, userValue))
{
    Console.WriteLine($"Value {userValue} exists in array");
}
else
{
    Console.WriteLine($"Value {userValue} do not exists in array");
}