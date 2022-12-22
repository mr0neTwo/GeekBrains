// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8 
// 918 -> 1

static int GetSecondDigit(int number)
{
    return (number / 10) % 10;
}

Console.WriteLine(GetSecondDigit(456));
Console.WriteLine(GetSecondDigit(782));
Console.WriteLine(GetSecondDigit(918));