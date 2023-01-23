// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

static double[,] GetRandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(10) + random.NextDouble();
        }
    }

    return array;
}

static void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2}  ");
        }

        Console.WriteLine();
    }
}

static int[] GetCoordsFromConsole()
{
    bool check = false;
    while (!check)
    {
        Console.Write("Введите координаты m и n через запятую: ");

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

        check = checkNumbers.All(checkNumber => checkNumber) && lenght == 2;

        if (check) return array;
        else Console.WriteLine("Некорректный ввод");
    }

    return Array.Empty<int>();
}

static double GetValue(double[,] array, int m, int n)
{
    double result = Double.NaN;

    if (array.GetLength(0) > m && array.GetLength(1) > n)
    {
        result = array[m, n];
    }

    return result;
}


double[,] array = GetRandomArray(4, 4);
Print2DArray(array);
Console.WriteLine();

int[] coords = GetCoordsFromConsole();

double value = GetValue(array, coords[0], coords[1]);
Console.WriteLine(double.IsNaN(value)
                ? "Такого элемента не существует"
                : $"Значения по координатам {coords[0]} {coords[1]}: {value:F2}");