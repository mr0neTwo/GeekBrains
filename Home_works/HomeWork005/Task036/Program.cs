
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// Предположим что, нечетные позиции это нечетные индексы 
static int SumOddElement(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}



int[] range = { -100, 100 };

int[] array = MakeRandomArray(arrayLength: 4, rangeOfNumber: range);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int sum = SumOddElement(array);
Console.WriteLine($"Сумма всех нечетных элементов: {sum} ");
