// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Так как в условии не понятно, откуда именно программа берет элементы массива, а уточнять долго, два варианта:

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

static void MakeAndPrintArray(bool isRandom = false)
{
    int  arrayLength = 8;
    int[] array = new int[arrayLength];
    var random = new Random();

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = isRandom ? random.Next(0, 100) : array[i] = GetIntFromConsole($"Введите число {i + 1}: ");
    }

    Console.WriteLine($" [ {String.Join(", ", array)} ] ");
}

// Вариант 1. Случайные элементы.
MakeAndPrintArray(isRandom: true);

// Вариант 2. Элементы вводятся с консоли.
MakeAndPrintArray();