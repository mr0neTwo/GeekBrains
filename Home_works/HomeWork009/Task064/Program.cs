// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
//
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

static void PrintNumbersFormNumberTo0(int number)
{
    if (number > 0)
    {
        Console.Write($"{number} ");
        PrintNumbersFormNumberTo0(number - 1);
    }
    else
    {
        Console.WriteLine();
    }
    
}

PrintNumbersFormNumberTo0(5);
PrintNumbersFormNumberTo0(8);