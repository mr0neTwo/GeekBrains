// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

static double[] GetPropertyFromConsole(int numberOfSetProperty)
{
    bool check = false;
    while (!check)
    {
        string message = $"Введите значения b{numberOfSetProperty} и k{numberOfSetProperty} через запятую " +
                         $"для функции y = k{numberOfSetProperty} * x + b{numberOfSetProperty}: ";
        Console.Write(message);

        string input = Console.ReadLine()!;
        string[] inputArray = input.Split(',');
        int lenght = inputArray.Length;
    
        double[] array = new double[lenght];
        bool[] checkNumbers = new bool[lenght];

        for (int i = 0; i < lenght; i++)
        {
            if (double.TryParse(inputArray[i], out array[i])) checkNumbers[i] = true;
            else checkNumbers[i] = false;
        }

        check = checkNumbers.All(checkNumber => checkNumber) && lenght == 2;
        
        if (check) return array;
        else Console.WriteLine("Некорректный ввод");
    }

    return Array.Empty<double>();
}

static bool IsDoubleEquivalent(double number1, double number2)
{
    double difference = Math.Abs(number1 * .0000001);
    return Math.Abs(number1 - number2) <= difference;
}

static void GetCrossPoint(double[] propsFunc1, double[] propsFunc2)
{
    
    // y = k1 * x + b1 = propsFunc1[0] * x + propsFunc1[1]
    // y = k2 * x + b2 = propsFunc2[0] * x + propsFunc2[1]
    // propsFunc1[0] * x + propsFunc1[1] = propsFunc2[0] * x + propsFunc2[1]
    // propsFunc1[0] * x - propsFunc2[0] * x = propsFunc2[1] - propsFunc1[1]
    // x * (propsFunc1[0] - propsFunc2[0]) = propsFunc2[1] - propsFunc1[1]
    // x = (propsFunc2[1] - propsFunc1[1]) / (propsFunc1[0] - propsFunc2[0])
    double crossX = (propsFunc2[1] - propsFunc1[1]) / (propsFunc1[0] - propsFunc2[0]);
    double crossY = propsFunc1[0] * crossX + propsFunc1[1];
    
    if (IsDoubleEquivalent(propsFunc1[0], propsFunc2[0]) && IsDoubleEquivalent(propsFunc1[1], propsFunc2[1]))
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (double.IsInfinity(crossX))
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        Console.WriteLine($"Прямые пересекутся в точке с координатами: X = {crossX:F2} Y = {crossY:F2}");
    }
    
}


double[] propsFunc1 = GetPropertyFromConsole(1);
double[] propsFunc2 = GetPropertyFromConsole(2);
GetCrossPoint(propsFunc1, propsFunc2);

