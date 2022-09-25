// Home task # 19  1 solution!
//--------------------
void Palindrome_Check()
{
    Console.WriteLine("Enter 5 digit number");
    string user_input = Console.ReadLine(); 
    int len = user_input.Length;
    bool result = true;
    for (int i=0; i < len/2; i++)
    {
        if (user_input[i] != user_input[len - i - 1])
        {
            result = false;
        }
    }
        if (result == false) Console.WriteLine($"{user_input} is not Palindrom");
        else Console.WriteLine($"{user_input} is Palindrom");
     
}
//Palindrome_Check();


// Home task # 19  2 solution!
//--------------------
void Palindrome_Check_1()
{
    Console.WriteLine("Enter 5 digit number");
    int user_input = Convert.ToInt32(Console.ReadLine()); 
    int temp_var, revers_number = 0;
    temp_var = user_input;
    while (user_input != 0)
    {
        revers_number = (revers_number * 10) + user_input % 10;
        user_input = user_input / 10;
    }
    if (temp_var == revers_number) Console.WriteLine($"{temp_var} is Palindrom");
    else Console.WriteLine($"{temp_var} is NOT Palindrom");

}
//Palindrome_Check_1();



// Home task # 21  
//--------------------

void Vector_length()
{
    int[] vect1 = new int[3];
    int[] vect2 = new int[3];
    Random rnd = new Random();
    double Vec_length = 0;
    for (int i = 0; i < 3; i++)
    {
        vect1[i] = rnd.Next(-100,101);
        vect2[i] = rnd.Next(-100,101);
        Vec_length += (Math.Pow((vect2[i] - vect1[i]),2));
        Vec_length = Math.Round(Math.Sqrt(Vec_length),3);
    }
    Console.WriteLine($"1 point -  |{vect1[0]}, {vect1[1]}, {vect1[2]}|");  
    Console.WriteLine($"2 point -  |{vect2[0]}, {vect2[1]}, {vect2[2]}|");
    Console.WriteLine($"Vector length = {Vec_length}");

}
//Vector_length();



// Home task # 23  
//--------------------
void Exponentiation()
{
    Console.WriteLine("Enter number ");
    int user_input = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i<=user_input; i++)
    {
        double result = Math.Pow(i,3);
        Console.WriteLine($"|{result}|");
    }
} 
Exponentiation();