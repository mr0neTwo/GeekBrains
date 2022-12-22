// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// <summary>
// Запрашивает ввод пятизначного числа.
// </summary>
// <param name="massage">Сообщение при вводе</param>
// <returns>Возвращает пятизначное число</returns>
static int Get5dNumberFromConsole(string massage)
{
    int number = 0;
    bool check = true;
    while (check)
    {
        Console.Write(massage);
    
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out number))
        {
            int absNumber = Math.Abs(number);
            if (absNumber > 9999 && absNumber < 100000)
            {
                check = false;
            }
            else
            {
                Console.WriteLine("Число должно быть пятизначным!");
            }
        }
        else
        {
            Console.WriteLine("Введенное значение не является числом!");
        }
    }

    return number;
}

// <summary>
// Проверяет является ли число палиндромом или нет, и печатает отчет в консоль
// </summary>
// <param name="number">Число</param>
static void CheckPalindrome(int number)
{
    string strNumber = number.ToString();

    char[] charArray = strNumber.ToCharArray();
    Array.Reverse(charArray);
    string reversStrNumber = new string(charArray);

    string result = strNumber == reversStrNumber ? "" : "не ";
    
    Console.WriteLine($"Число {number} {result}является палиндромом");
    
}

int number = Get5dNumberFromConsole("Введите пятизначное число: ");

CheckPalindrome(number);