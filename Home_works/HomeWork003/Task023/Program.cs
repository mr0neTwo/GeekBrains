// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// <summary>
// Запрашивает ввод целого числа из консоли.
// </summary>
// <param name="massage">Сообщение при вводе</param>
// <returns>Возвращает число</returns>
static int GetNumberFromConsole(string massage)
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

// <summary>
// Рассчитывает и печатает в консоль таблицу кубов последовательности от 1 до count
// </summary>
// <param name="count">Целое число</param>
static void PrintTableCubs(int count)
{
    Console.Write("{ ");
    for (int i = 1; i <= count; i++)
    {
        Console.Write(Math.Pow(i, 3) + (i == count ? "" : ", "));
    }
    Console.WriteLine(" }");
}


int count = GetNumberFromConsole("Введите целое число: ");
PrintTableCubs(count);