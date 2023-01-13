// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


static double GetDoubleFromConsole(string massage)
{
    double number = 0;
    bool check = true;
    while (check)
    {
        Console.Write(massage);
    
        string input = Console.ReadLine()!;
        if (double.TryParse(input, out number))
        {
            check = false;
        }
        else
        {
            Console.WriteLine("Некорректный ввод!");
        }
    }

    return number;
}

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

static double Power(double number, int power)
{
    double result = number;
    for (int i = 1; i < power; i++)
    {
        result *= number;
    }

    return result;
}

double number = GetDoubleFromConsole("Введите число: ");
int power = GetIntFromConsole("Введите степень числа: ");
double result = Power(number, power);

Console.WriteLine($"Число {number} в степени {power} равно {result}.");