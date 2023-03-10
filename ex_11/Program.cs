// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int new_number = number / 100 * 10  + number % 10;

Console.WriteLine($"num: {number}, new_number {new_number}");