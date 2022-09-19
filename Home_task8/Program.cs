bool Even_number (int num)
{
    bool result=true;
    int number = Math.Abs(num % 2);
    if (number > 0) {result=false;}     
    return result;
        
}
int num1 = 0;
int num2 = 1;
while (num1 <= 0)
{
    Console.Write("Enter a positive number : ");
    num1 = Convert.ToInt32(Console.ReadLine());

        while (num2 <= num1)
        {
            bool num3 = Even_number(num2);
            if (num3) 
            {
                Console.WriteLine(num2);
            }
            num2++;
        }
}
