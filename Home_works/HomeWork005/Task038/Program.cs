
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//
// [3 7 22 2 78] -> 76

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
            Console.WriteLine("Число должно быть вещественным!");
        }
    }

    return number;
}

static double[] MakeArray(int arrayLength, bool isRandom = false)
{
    double[] array = new double[arrayLength];
    var random = new Random();

    for (int i = 0; i < arrayLength; i++)
    {
        if (isRandom)
        {
            array[i] = random.NextDouble() * random.Next();
        }
        else
        {
            array[i] = GetDoubleFromConsole($"Введите вещественное число {i + 1}: ");
        }
    }

    return array;
}

static double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    
    return max - min;
}

double[] array = MakeArray(5, true);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

double diff = DiffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");