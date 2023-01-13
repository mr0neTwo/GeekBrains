// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//
// 452 -> 11
// 82 -> 10
// 9012 -> 12

static int GetIntFromConsole(string massage)
{
    int number = 0;
    bool check = true;
    while (check)
    {
        Console.Write(massage);
    
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out number))
        {
            check = false;
        }
        else
        {
            Console.WriteLine("Число должно быть целым!");
        }
    }

    return number;
}

int SumOfDigit(int number)
{
    int sum = 0;
    while(number % 10 > 0 || number / 10 != 0) // пока есть какой либо остаток от деления на 10
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    
    return sum;
}

int number = GetIntFromConsole("Введите целое число: ");
int result = SumOfDigit(number);

Console.WriteLine($"Сумма цифр числа {number} равна {result}.");