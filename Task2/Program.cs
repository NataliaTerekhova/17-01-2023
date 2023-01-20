// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
//System.Console.WriteLine(number);
int result = (number / 100) * 10 + number % 10;

System.Console.WriteLine($"{number} -> {result}");
