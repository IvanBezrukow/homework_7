string FillArray(int[,] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101);
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

double SumInColumns(int[,] array, int count)
{
    double sum = 0;
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == count) sum = sum + array[i, j];
                else continue;
            }
        }
    }
    return sum;
}




try
{
    Console.Write("Insert the number of rows in the array = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert the number of columns in the array = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (rows > 1 && columns > 1)
    {
        int[,] mainArray = new int[rows, columns];
        FillArray(mainArray);
        Console.WriteLine("The generated array:");
        Console.WriteLine();
        PrintArray(mainArray);
        Console.WriteLine();
        int count = 0;
        while (count < columns)
        {
            switch (count)
            {
                case 0:
                    Console.Write($"The arithmetic average of the numbers in the first column of the array ===> ");
                    Console.Write($"{Math.Round(SumInColumns(mainArray, count) / columns, 1)}");
                    Console.WriteLine();
                    break;
                case 1:
                    Console.Write($"The arithmetic average of the numbers in the second column of the array ===> ");
                    Console.Write($"{Math.Round(SumInColumns(mainArray, count) / columns, 1)}");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write($"The arithmetic average of the numbers in the third column of the array ===> ");
                    Console.Write($"{Math.Round(SumInColumns(mainArray, count) / columns, 1)}");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write($"The arithmetic average of the numbers in the fifth column of the array ===> ");
                    Console.Write($"{Math.Round(SumInColumns(mainArray, count) / columns, 1)}");
                    Console.WriteLine();
                    break;
                default:
                    Console.Write($"The arithmetic average of the numbers in the {count + 1}th column of the array ===> ");
                    Console.Write($"{Math.Round(SumInColumns(mainArray, count) / columns, 1)}");
                    Console.WriteLine();
                    break;
            }
            count++;
        }
    }
    else Console.WriteLine("Insert at least numbers greater than 1");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}