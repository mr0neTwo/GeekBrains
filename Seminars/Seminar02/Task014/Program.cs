// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.
//
// 14 -> нет 
// 46 -> нет 
// 161 -> да

static void IsMultiplesOf7or23(int number)
{
    bool check = number % 7 == 0 && number % 23 == 0;
    string massage = check ? "да" : "нет";
    Console.WriteLine(massage);
}

IsMultiplesOf7or23(14);
IsMultiplesOf7or23(46);
IsMultiplesOf7or23(161);