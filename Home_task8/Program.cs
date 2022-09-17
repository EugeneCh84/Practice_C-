bool Even_number (int num)
{
    bool result=true;
    int number = num % 2;
    if (number > 0) result=false ; 
    return result;
        
}
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
while (num1 <= num)
{
    bool num2 = Even_number(num1);
    if (num2) Console.Write($"{num1}  ");
    num1++;
} 