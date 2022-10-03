// Task # 25



void Num_multipl()
{
Console.WriteLine("Enter number");
int base_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter degree of number");
int num_degree = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i=1; i <=num_degree; i++)
    {
        result *= base_num;
        
    }
    Console.WriteLine(result);
}
//Num_multipl();




// Task # 27

void Summ_of_numbers()
{
Console.WriteLine("Enter number");
int base_num = Convert.ToInt32(Console.ReadLine());
int result = 0, temp_var = 0;
//int temp_var = 0;
while (base_num != 0)
    {
        temp_var = base_num % 10;
        result += Math.Abs(temp_var); 
        base_num = base_num / 10;


    }
    Console.WriteLine(result);
}
//Summ_of_numbers();



// Task # 29

void Array()
{
int[] arr = new int[8];
Random rnd = new Random();
//int z = 0;
for (int i=0; i<arr.Length; i++)
    {
        arr[i] = rnd.Next(-1000,1000);
    }
    for (int i=0; i<arr.Length; i++)
    {    
        for (int j=0; j<arr.Length-1; j++)
            {
                if (Math.Abs(arr[j]) > Math.Abs(arr[j+1]))
                    {
                        int z = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = z;
                    }
            }
        
    }
for (int i=0; i<arr.Length; i++)
   {Console.WriteLine($"{arr[i]}");}
    

}
Array();