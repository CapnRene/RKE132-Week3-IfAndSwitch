//V6tab arvutist kuup2eva ja n2itab millise n2dalap2evaga on tegu

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 1)
{
    Console.WriteLine("Today is Monday");
}
else if (weekDay == 2)
{
    Console.WriteLine("Today is Tuesday");
}
else if (weekDay == 3)
{
    Console.WriteLine("Today is Wednesday");
}
else if (weekDay == 4)
{
    Console.WriteLine("Today is Thursday");
}
else if (weekDay == 5)
{
    Console.WriteLine("Today is Friday");
}
else if (weekDay == 6)
{
    Console.WriteLine("Today is Saturday");
}
else if (weekDay == 0)
{
    Console.WriteLine("Today is Sunday");
}
else
{
    Console.WriteLine("Error in receiving an integer");
}
Console.WriteLine("Have a nice day!");