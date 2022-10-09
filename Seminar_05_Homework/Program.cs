
void Fill_array(int[] my_array, int minValue, int maxValue)
{
    Random rnd = new Random();
        for (int i=0; i < my_array.Length; i++)
        {
            my_array[i] = rnd.Next(minValue,maxValue);
        }
}

void Print_array(int[] my_array)
{      
    for (int i=0; i < my_array.Length; i++)
        {
            Console.Write(my_array[i] + "  ");
        }
        Console.WriteLine();
}






//   Task #34

void Even_Numbers()
{
    Console.WriteLine("Enter array length");
    int array_length = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    int minValue = 0;
    int maxValue = 1000;
    int[] my_array = new int[array_length]; 
    Fill_array(my_array, minValue, maxValue);
    for (int i = 0; i < array_length; i++)
        {
            if (my_array[i] % 2 == 0)
                {
                    result ++;
                }
        }
        Print_array(my_array);
        Console.WriteLine($"{result} even numbers in array" );
}
//Even_Numbers();





//   Task #36

void Summ_of_UnEvenIndex_Numbers()
{
    Console.WriteLine("Enter array length");
    int array_length = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    int minValue = -99;
    int maxValue = 100;
    int[] my_array = new int[array_length]; 
    Fill_array(my_array, minValue, maxValue);
    for (int i = 1; i < array_length; i += 2)
        {
            result += my_array[i];
        }
        //Fill_array(my_array);
        Print_array(my_array);
        Console.WriteLine($"Summ of uneven index numbers of array = {result}" );
}
//Summ_of_UnEvenIndex_Numbers();




//   Task #38   я не смог решить задачу используя методы Find_Max и Find_Min
//              не понял как это реализовать.


void Diff_Max_Min_array()
{
    Console.WriteLine("Enter array length");
    int array_length = Convert.ToInt32(Console.ReadLine());
    double[] my_array1 = new double[array_length]; 
    Fill_array_double (my_array1);
    // Find_Max(my_array1,max);
    // Find_Min(my_array1,min);
        
    double max = my_array1[0];
    for (int i = 1; i < my_array1.Length; i++ )
        {
            if (my_array1[i] > max) 
                {
                    max = my_array1[i];
                }
        }
         Console.WriteLine($"Max value of array  {max}");
        Console.WriteLine();

    double min = my_array1[0];
    for (int i = 1; i < my_array1.Length; i++ )
        {
            if (my_array1[i] < min) 
                {
                    min = my_array1[i];
                }
        }

    Console.WriteLine($"Min value of array  {min}");
    Console.WriteLine();

    double result = max - min;
        
    Console.WriteLine($"Diff between max & min   {result}");
    
}
Diff_Max_Min_array();




void Fill_array_double (double[] my_array1)
{
    Random rnd = new Random();
        for (int i=0; i < my_array1.Length; i++)
        {
            my_array1[i] = Math.Round(rnd.NextDouble(),2);
            int temp = rnd.Next(-100,101);
            my_array1[i] += temp;
            Console.Write(my_array1[i] + "   ");
        }
        Console.WriteLine();
}
//Fill_array_double();

void Find_Max(double[] my_array1, double max)
{   
    max = my_array1[0];
    for (int i = 1; i < my_array1.Length; i++ )
    {
        if (my_array1[i] > max) 
        {
            max = my_array1[i];
        }
    }
    // Console.WriteLine($"Max number of array     {max}");
    // Console.WriteLine();
    //return (max);
    
}


void Find_Min(double[] my_array1, double min)
{   
    min = my_array1[0];
    for (int i = 1; i < my_array1.Length; i++ )
    {
        if (my_array1[i] < min) 
        {
            min = my_array1[i];
        }
    }
    // Console.WriteLine(min);
    // Console.WriteLine();
    //return (min);
}  