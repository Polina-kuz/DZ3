using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Задание 4.1");
Console.WriteLine("Введи число от 1 до 365 (номер дня в году)");
string number = Console.ReadLine();
int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 30, 31, 30, 31, 30, 31 };
if (int.TryParse(number, out int NumOfDay)) ;
{
    int Month = 0;
    while (NumOfDay > DaysInMonth[Month])
    {
        NumOfDay -= DaysInMonth[Month];
        Month++;
    }
    DateTime Data = new DateTime(2026, Month + 1, NumOfDay);
    Console.WriteLine(Data);
}

Console.WriteLine("Задание 4.2");
Console.WriteLine("Введи число от 1 до 365 (номер дня в году)");
string Number = Console.ReadLine();
int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 30, 31, 30, 31, 30, 31 };
if (int.TryParse(number, out int numOfDay)) ;
{
    if (0 < numOfDay  && numOfDay <= 365)
    {
        int month = 0;
        while (numOfDay > daysInMonth[month])
        {
            numOfDay -= daysInMonth[month];
            month++;
        }
        DateTime data = new DateTime(2026, month + 1, numOfDay);
        Console.WriteLine(data);
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}

Console.WriteLine("Домашнее задание 4.1");
Console.WriteLine("Введи число");
string numb  = Console.ReadLine();
Console.WriteLine("Введи год");
string year  = Console.ReadLine();
if ((int.TryParse(numb, out int NumbOfDay)) && (int.TryParse(year, out int Year)))
{
    if (0 < NumbOfDay && NumbOfDay <= 366 && (Year % 4 == 0 || Year % 400  == 0) && Year % 100 != 0)
    {
        int[] Daysinmonth = { 31, 28, 31, 30, 31, 30, 30, 31, 30, 31, 30, 31 };
        int mmonth = 0;
        while (NumbOfDay > Daysinmonth[mmonth])
        {
            NumbOfDay -= Daysinmonth[mmonth];
            mmonth++;
        }
        DateTime Ddata = new DateTime(Year, mmonth + 1, NumbOfDay);
        Console.WriteLine(Ddata);
    }
    else if (0 < NumbOfDay && NumbOfDay <= 366)
    {
        int[] Daysinmonth = { 31, 28, 31, 30, 31, 30, 30, 31, 30, 31, 30, 31 };
        int mmonth = 0;
        while (NumbOfDay > Daysinmonth[mmonth])
        {
            NumbOfDay -= Daysinmonth[mmonth];
            mmonth++;
        }
        DateTime Ddata = new DateTime(Year, mmonth + 1, NumbOfDay);
        Console.WriteLine(Ddata);
    }
    else 
    {
        Console.WriteLine("Ошибка");
    }
}  