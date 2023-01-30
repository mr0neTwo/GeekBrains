// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


static int SunNumbersFormNToM(int m, int n)
{
    if (m >= n) return n;
    
    return m + SunNumbersFormNToM(m + 1, n);
}

int m = 1, n = 15;

int sum = SunNumbersFormNToM(m, n);
Console.WriteLine($"Сумма числе в диапазоне от {m} до {n} равна {sum}");

