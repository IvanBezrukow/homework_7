string FillArray(int[,] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-50, 51);
        }
    }
    return result;
}

string PrintArray(int[,] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}\t");
        }
        Console.WriteLine();
    }
    return result;
}

string CheckNumber(int[,] array, int value)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value)
            {
                Console.WriteLine($"THERE IS such a number ({value}) in the array");
                return result;
            }
            else continue;
        }
    }
    Console.WriteLine($"THERE IS NO such a number ({value}) in the array");
    return result;
}




try
{
    Console.Write("Insert the number of rows in the array = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert the number of columns in the array = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert the number you are searching for: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (rows > 1 && columns > 1)
    {
        int[,] mainArray = new int[rows, columns];
        FillArray(mainArray);
        Console.WriteLine("The generated array:");
        Console.WriteLine();
        PrintArray(mainArray);
        Console.WriteLine();
        Console.WriteLine($"{CheckNumber(mainArray, num)}");
    }
}
catch
{
    Console.WriteLine("You nay insert only numbers");
}