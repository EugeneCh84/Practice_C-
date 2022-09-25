void Rnd_1()
{
    Random rnd = new Random();
    int number = rnd.Next(100,1000);
    Console.WriteLine(number);
    int tens = number / 10 % 10;
    int ones = number % 10;
    int hundr = number / 100;
    Console.WriteLine($"{hundr} {ones}");
    //Console.WriteLine(ones);
    
}
// Rnd_1();


void Mod_check()
{
    Console.WriteLine("Enter 2 numbers");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 % num2 == 0)
    {
        Console.WriteLine("Chilso kratno");
    }
    else
    {
        Console.WriteLine($"Chisla ne kratno, ostatok {num1%num2}");
    }
}
// Mod_check();

void Mod_check1()
{
    int num1 = 7;
    int num2 = 23;
    Console.WriteLine("Enter number");
    int num = Convert.ToInt32(Console.ReadLine());
        if (num % num1 == 0 && num % num2 == 0)
    {
        Console.WriteLine("Chilso kratno");
    }
    else
    {
                Console.WriteLine($"Chislo ne kratno");
    }
}
// Mod_check1();


void Squar_check()
{
    Console.WriteLine("Enter 2 numbers");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1*num1 == num2 || num1 == num2*num2)
    {
        Console.WriteLine("Kvadrat");
    }
    else
    {
        Console.WriteLine("Ne Kvadrat");
    }
}
//Squar_check();


void Find_3_digit()
{
    int input_number = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(input_number) > 99)
    {
    int inc_result = 0;
    int temp_var = input_number;
    while (Math.Abs(temp_var) > 0)
    {
        temp_var = temp_var / 10;
        inc_result +=1;
    }
    for (int i=1; i<inc_result-2; i++)
    {
        input_number = input_number / 10;
    }
    Console.WriteLine($"{Math.Abs(input_number % 10)}");
    }
    else 
    {
        Console.WriteLine("No 3 digit");
    }
}    
Find_3_digit();