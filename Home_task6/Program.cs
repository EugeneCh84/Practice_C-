bool Even_number (int num)
{
    bool number=true;
    int result = num % 2;
    if (result > 0) number=false ; 
    return number;
        
}

Console.Write("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
bool number2 = Even_number(number1);
if (number2)
{
    Console.WriteLine($"Число четное:  {number2}");
}
else
{
    Console.WriteLine($"Число нечетное:  {number2}");
}