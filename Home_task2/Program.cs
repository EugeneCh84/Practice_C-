Console.Write("Enter 1 number:  ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2 number:  ");
int num_2 = Convert.ToInt32(Console.ReadLine());
while (num_1 == num_2)
{
    Console.WriteLine("Numbers are the same, enter another number!");
    num_2 = Convert.ToInt32(Console.ReadLine());
}
if ( num_1 > num_2)
{
    Console.WriteLine($"Number {num_1} > then number {num_2}");
}
else
{
    Console.WriteLine($"Number {num_2} > then number {num_1}");
}