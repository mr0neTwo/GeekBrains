/**
 * __Задача 15.__
 * Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 * и проверяет, является ли этот день выходным.
 *
 * + 6 -> да
 * + 7 -> да
 * + 1 -> нет
 */

static string IsWeekend(int weekDay)
{
    string message = "День все диапазона, пожалуйста введите число от 1 до 7";
    if (weekDay > 0 && weekDay < 6 ) message = "нет";
    if (weekDay == 6 || weekDay == 7 ) message = "да";
    return message;
}

Console.WriteLine(IsWeekend(6));
Console.WriteLine(IsWeekend(7));
Console.WriteLine(IsWeekend(1));
Console.WriteLine(IsWeekend(0));
