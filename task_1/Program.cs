string FillArray(double[,] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble() * 10, 1);
        }
    }
    return result;
}

string PrintArray(double[,] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j],3}\t");
        }
        Console.WriteLine();
    }
    return result;
}




try 
{
    Console.Write("Insert the number of rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert the number of columns = "); 
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] mainArray = new double[rows, columns]; 
    Console.Clear();
    FillArray(mainArray);
    PrintArray(mainArray);
}
catch 
{
    Console.WriteLine("You may insert only numbers"); 
}