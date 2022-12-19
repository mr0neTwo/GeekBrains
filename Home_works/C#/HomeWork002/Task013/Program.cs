// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

static string GetSecondDigit(int number)
{
    var stringNumber = number.ToString();
    return stringNumber.Length > 2 ? stringNumber[2].ToString() : "третьей цифры нет";
}

Console.WriteLine(GetSecondDigit(645));
Console.WriteLine(GetSecondDigit(78));
Console.WriteLine(GetSecondDigit(32679));