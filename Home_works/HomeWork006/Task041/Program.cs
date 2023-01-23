// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

static int[] GetArrayFromConsole()
{
    bool check = false;
    while (!check)
    {
        Console.Write("Введите числа через запятую: ");

        string input = Console.ReadLine()!;
        string[] inputArray = input.Split(',');
        int lenght = inputArray.Length;
    
        int[] array = new int[lenght];
        bool[] checkNumbers = new bool[lenght];

        for (int i = 0; i < lenght; i++)
        {
            if (int.TryParse(inputArray[i], out array[i])) checkNumbers[i] = true;
            else checkNumbers[i] = false;
        }

        check = checkNumbers.All(checkNumber => checkNumber);
        
        if (check) return array;
        else Console.WriteLine("Некорректный ввод");
    }

    return Array.Empty<int>();
}

static int CountPositiveNumbers(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number > 0) count++;
    }

    return count;
}


int[] array = GetArrayFromConsole();
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int count = CountPositiveNumbers(array);
Console.WriteLine($"Количество положительных чисел: {count}");
