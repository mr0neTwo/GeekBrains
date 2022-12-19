// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

static void CheckSquare(int number1, int number2)
{
    bool check = number1 == number2 * number2 || number2 == number1 * number1;
    string massage = check ? "да" : "нет";
    Console.WriteLine(massage);
}

CheckSquare(5, 25);
CheckSquare(-4, 16);
CheckSquare(25, 5);
CheckSquare(8, 9);