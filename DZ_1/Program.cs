//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
using System;

Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());

if (number < 100)
    Console.WriteLine("Это не трёхзначное число!!!");
else 
    Console.WriteLine(number / 10 % 10);
