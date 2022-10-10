// Task # 41
//================================
void User_Input(int[] arr, int m)
{        
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Enter {i} number of array = ");
        arr[i] = Convert.ToInt32(Console.ReadLine());       
    }  
}


void Positive_Array_Value()
{
    Console.WriteLine("Enter M = ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[m];
    User_Input(arr,m);
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                {
                    count ++;
                }
        }
        Console.WriteLine($"Array values > 0  --->  ! {count} !");
}
//Positive_Array_Value();


// Task # 43 
//================================

void Line_Crossing()
{
    Console.WriteLine("Enter points k1, k2, b1, b2");
    decimal k1 = Convert.ToDecimal(Console.ReadLine());
    decimal k2 = Convert.ToDecimal(Console.ReadLine());
    decimal b1 = Convert.ToDecimal(Console.ReadLine());
    decimal b2 = Convert.ToDecimal(Console.ReadLine());
    decimal x=0; 
    decimal y=0;
    if (k1 != k2)
    {
        x = (b2 - b1)/(k1 - k2);
        y = k1*x + b1;
        Console.WriteLine($"Crosspoint  --->  ( {Math.Round(x,2)} ; {Math.Round(y,2)} ) ");
    }
    else {Console.WriteLine("Lines are parallel");}
    
}
Line_Crossing();