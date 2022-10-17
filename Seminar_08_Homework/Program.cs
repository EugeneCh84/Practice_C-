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


void PrintArray1(int[,] numbers, int rows, int columns)
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




// Task  # 54
void Array_Sort()
{
Console.WriteLine("Enter array size, M and N");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows,columns];
FillArray(numbers,rows,columns);
PrintArray1(numbers,rows,columns);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < numbers.GetLength(1) - 1; k++)
        {
            if (numbers[i, k] < numbers[i, k + 1]) 
            {
                int temp = 0;
                temp = numbers[i, k];
                numbers[i, k] = numbers[i, k + 1];
                numbers[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine();
PrintArray1(numbers,rows,columns);
}
//Array_Sort();




// Task  # 56
void Array_Min_String()
{
Console.WriteLine("Enter array size, M and N");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows,columns];
FillArray(numbers,rows,columns);
PrintArray1(numbers,rows,columns);
int[] result = new int[rows];
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        result[i] += numbers[i, j];        
    }
}
int min = result[0];
int line = 0;
for (int i = 0; i<result.Length; i++)
    {      
        if (result[i] < min) 
        {
            min = result[i];
            line = i;
        }       
    }
    Console.WriteLine($"Minimum sum of element {min} in the {line} row ");
}
//Array_Min_String();


// Task  # 58
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}