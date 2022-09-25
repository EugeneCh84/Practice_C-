// Home task # 10
// -----------------------------------------
void Show_third_digit()
{
    string user_number = "";
    while (user_number.Length != 3)
    {
        Console.WriteLine("Enter 3 digit number");
        user_number = Console.ReadLine();

    }
    int user_number_digit = Convert.ToInt32(user_number);
    int third_digit = user_number_digit / 10 % 10;
    Console.WriteLine(third_digit);

}
//Show_third_digit();
//-------------------------------------------


// Home task # 13
// ------------------------------------------
void Show_third_digit_1()
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
//Show_third_digit_1();
//-------------------------------------------

// Home task # 15
//-------------------------------------------
void Holiday_check()
{
    Console.WriteLine("Enter Day of Week number");
    int day = Convert.ToInt32(Console.ReadLine());
    
    switch (day)
    {
        case 1:
            Console.WriteLine("Not a holiday, It's Monday");
        break;

        case 2:
            Console.WriteLine("Not a holiday, It's Tuesday");
        break;

        case 3:
            Console.WriteLine("Not a holiday, It's Wednesday");
        break;

        case 4:
            Console.WriteLine("Not a holiday, It's Thursday");
        break;

        case 5:
            Console.WriteLine("Not a holiday, It's Friday");
        break;

        case 6:
            Console.WriteLine("It is a holiday, It's Saturday");
        break;

        case 7:
            Console.WriteLine("It is a holiday, It's Sunday");
        break;

        default:
            Console.WriteLine("Please enter correct Day of Week");
        break;
    }
    
}
//Holiday_check();


// Home task # 15_1 (another solution)
//-------------------------------------------
void Holiday_check_1()
{
    string[] DayofWeek = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday",
                                        "Friday", "Saturday", "Sunday"};
    Console.WriteLine("Enter day of week number");
    int day_number = Convert.ToInt32(Console.ReadLine()) - 1;
    if (day_number == 6 || day_number == 7) 
    {
        Console.WriteLine($"It's a Holiday, {DayofWeek[day_number]}");
    }
    else
    {
        Console.WriteLine($"It's not a Holiday, {DayofWeek[day_number]}");
    }
}
Holiday_check_1 ();