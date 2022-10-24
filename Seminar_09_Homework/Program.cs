
// Task # 64

String Recursion (int m, int n) 
{
    if (m > n) 
    {
        if (m == n) 
        {
            return Convert.ToString(m);
        }
        return m + " " + Recursion(m - 1, n);
    } 
    else 
    {
        if (m == n) 
        {
            return Convert.ToString(m);
        }
        return m + " " + Recursion(m + 1, n);
    }
}
void Recursion_output ()
{
    Console.WriteLine("Enter 1 number");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter 2 number");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Recursion (a,b));
}
//Recursion_output();


// Task # 66

void Recursion1 (int m, int n, int summ) 
{
    if (m > n) 
    {
        if (m == n) 
        {
            Console.WriteLine(m);
            return;
        }
        Console.WriteLine(summ);
        return ;       
    } 
        summ = summ + (m++);
        Recursion1(m, n, summ);   
       
}

void Recursion_output1 ()
{
    Console.WriteLine("Enter 1 number");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter 2 number");
    int b = Convert.ToInt32(Console.ReadLine());
    Recursion1 (a,b,0);
    
}
//Recursion_output1();



// Task # 68

int Recursion2(int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0) 
    {
        return Recursion2(m - 1, 1);
    } 
    else 
    {
        return Recursion2(m - 1, Recursion2(m, n - 1));
    }
}

void Recursion_output2 ()
{
    Console.WriteLine("Enter 1 number");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter 2 number");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Recursion2 (a,b));
    
}
Recursion_output2();
