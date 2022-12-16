/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
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

int firstNumber = GetNumberFromConsole("Введите первое целое число: ");
int secondNuber = GetNumberFromConsole("Введите второе целое число: ");

if (firstNumber > secondNuber)
{
    Console.WriteLine($"Число {firstNumber} больше числа {secondNuber}");
}
else
{
    Console.WriteLine($"Число {secondNuber} больше числа {firstNumber}");
}