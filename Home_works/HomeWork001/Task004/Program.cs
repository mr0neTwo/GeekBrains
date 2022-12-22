/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

static int GetNumberFromConsole(string massage)
{
    int number = 0;
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

int arrayLength = 3;

int[] numbers = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    numbers[i] = GetNumberFromConsole( $"Введите число {i + 1}: ");
}

Console.WriteLine($"Максимальное введенное число это {numbers.Max()}.");