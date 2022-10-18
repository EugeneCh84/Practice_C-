//Task  # 52

void ColumnsAverage()
{
    Console.WriteLine("Enter array size, M and N");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[rows,columns];
    FillArray(numbers,rows,columns);
    PrintArray(numbers,rows,columns);
    int[] result = new int[columns];
    
    for (int i=0; i<columns; i++)
    {
        
        for (int j=0; j<rows; j++)
        {
            result[i] += numbers[j,i];
        }
        
    }
    Console.WriteLine("Average of columns");
    foreach (double val in result)
    {
        Console.WriteLine(Math.Round(val/rows,2));
        Console.WriteLine();
    }
}
ColumnsAverage();


void FillArray(int[,] numbers, int rows, int columns)
{
    Random random = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}


void PrintArray(int[,] numbers, int rows, int columns)
{
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}