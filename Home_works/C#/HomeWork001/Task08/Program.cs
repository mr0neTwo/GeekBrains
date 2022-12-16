/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

static int GetNumberFromConsole(string massage)
{
    int number;
    while (true)
    {
        Console.Write(massage);
    
        string input = Console.ReadLine();
        if (int.TryParse(input, out number)) break;
    
        Console.WriteLine("Число должно быть целым!");
    }

    return number;
}

int number = GetNumberFromConsole("Введите целое число: ");

Console.Write("{");
for (int i = 2; i <= number; i += 2)
{
    Console.Write(i + (i == number | i == number - 1 ? "" : ", " ));
}
Console.WriteLine("}");
