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


void PrintArrayDouble(double[,] numbers, int rows, int columns)
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

// Task   # 47

void FillArrayDouble()
{
    Console.WriteLine("Enter array size, M and N");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    double[,] numbers = new double[rows,columns]; 
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            numbers[i,j] = Math.Round(random.NextDouble(),1);
            int temp = random.Next(-9,10);
            numbers[i,j] += temp;
            
        }
    }
    PrintArrayDouble(numbers,rows,columns);
}
//FillArrayDouble();



//Task  # 50
void ValueSearch()
{
    Console.WriteLine("Enter array size, M and N");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[rows,columns];
    FillArray(numbers,rows,columns);
    PrintArray(numbers,rows,columns);
    Console.WriteLine("Enter index of array value, i and j");
    int I = Convert.ToInt32(Console.ReadLine());
    int J = Convert.ToInt32(Console.ReadLine());
    try
    {
        if (I>=0 || I<=rows || J>=0 || J<=columns)
            {
                Console.WriteLine($"Value in position [{I},{J}] is {numbers[I,J]}");
            }
    }
    catch (IndexOutOfRangeException ex) 
    
    {
        Console.WriteLine("No such value in array");
    }

    
}
//ValueSearch();


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
    
    for (int i=0; i<rows; i++)
    {
        
        for (int j=0; j<columns; j++)
        {
            result[i] += numbers[j,i];
        }
        
    }
    Console.WriteLine("Average of columns");
    foreach (double val in result)
    {
        Console.WriteLine(Math.Round(val/columns,2));
        Console.WriteLine();
    }
}
ColumnsAverage();