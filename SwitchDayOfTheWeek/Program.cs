//V6tab arvutist kuup2eva ja n2itab millise n2dalap2evaga on tegu kasutades switchi

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); // Tagastab v22rtuse 0-6, kus 0 on pyhap2ev

Console.WriteLine(weekDay);

switch(weekDay) // Kontrollib, kas weekDay v22rtus on 0-6
{
    case 1:
        Console.WriteLine("Today is Monday");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday");
        break;
    case 4:
        Console.WriteLine("Today is Thursday");
        break;
    case 5:
        Console.WriteLine("Today is Friday");
        break;
    case 6:
        Console.WriteLine("Today is Saturday");
        break;
    case 0:
        Console.WriteLine("Today is Sunday");
        break;
    default:
        Console.WriteLine("Error in receiving an integer");
        break;
}

Console.WriteLine("Have a nice day!");