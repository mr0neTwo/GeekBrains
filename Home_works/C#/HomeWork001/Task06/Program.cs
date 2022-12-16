/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

static int GetNumberFromConsole(string massage)
{
    int number;
    bool check = true;
    while (check)
    {
        Console.Write(massage);
    
        string input = Console.ReadLine();
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

int number = GetNumberFromConsole("Введите целое число: ");

string definition = number % 2 == 0 ? "четное" : "нечетное";

Console.WriteLine($"Число {number} {definition}.");

