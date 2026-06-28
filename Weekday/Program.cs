Console.WriteLine("Weekday Calculator");
Console.WriteLine(" Enter the Weekday Number");

int week = int.Parse(Console.ReadLine());
Weekday wd = new Weekday();

if (week == 1)
{
    wd.MessageLog("The Day is Sunday");
}
else if (week == 2)
{
    wd.MessageLog("The Day is Monday");
}
else if (week == 3)
{
    wd.MessageLog("The Day is Tuesday");
}
else if (week == 4)
{
    wd.MessageLog("The Day is Wednesday");
}
else if (week == 5)
{
    wd.MessageLog("The day is thusday");

}
else if (week == 6)
{
    wd.MessageLog("The Day is Friday");
}
else if (week == 7)
{
    wd.MessageLog("The Day is Saturday");
}
else
{
    wd.MessageLog("Wrong Entered Value");
}

