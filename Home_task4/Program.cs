int Max_number(int first_num, int second_num, int third_num)
{
    int result = first_num;
    if (second_num > result) result = second_num;
    if (third_num > result) result = third_num;
    return result;
}
Console.WriteLine("Enter 1 number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2 number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3 number");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = Max_number(num1,num2,num3);
Console.WriteLine($"Maximum number:  {max}");
