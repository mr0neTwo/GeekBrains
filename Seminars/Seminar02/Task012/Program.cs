// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

static void CheckDiv(int number1, int number2)
{
    int remainder = number1 % number2;
    string massage = remainder == 0 ? "кратно" : $"не кратно, остаток {remainder}";
    Console.WriteLine(massage);
}

CheckDiv(34, 5);
CheckDiv(16, 4);