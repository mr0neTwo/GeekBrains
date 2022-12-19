// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {randomNumber}");
int relult = (randomNumber / 100) * 10 + randomNumber % 10
Console.WriteLine($"Число без второй цыфры: {relult}");