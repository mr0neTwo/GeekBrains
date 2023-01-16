
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//
// [345, 897, 568, 234] -> 2

static int[] MakeRandomArray(int  arrayLength, int[] rangeOfNumber)
{
    int[] array = new int[arrayLength];
    var random = new Random();

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = random.Next(rangeOfNumber[0], rangeOfNumber[1]);
    }

    return array;
}

static int[] CountOfEvenOdd(int[] array)
{
    int countEven = 0;
    int countOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEven++;
        }
        else
        {
            countOdd++;
        }
    }
    int[] result  = {countEven, countOdd };
    return result;
}


int[] range = { 100, 1000 };

int[] array = MakeRandomArray(arrayLength: 10, rangeOfNumber: range);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int[] sumResults = CountOfEvenOdd(array);
Console.WriteLine($"Количество четных чисел массива: {sumResults[0]}");
Console.WriteLine($"Количество нечетных чисел массива: {sumResults[1]}");