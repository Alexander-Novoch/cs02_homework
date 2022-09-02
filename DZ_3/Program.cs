//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using System;

Console.WriteLine("Введите цифру:");
int Nday = int.Parse(Console.ReadLine());

if (Nday > 7)
    Console.WriteLine("Это не день недели!!!");
else if (Nday == 1)
        Console.WriteLine("Понедельник");
    else if (Nday == 2)
            Console.WriteLine("Вторник");
        else if (Nday == 3)
            Console.WriteLine("Среда");
            else if (Nday == 4)
                Console.WriteLine("Четверг");
                else if (Nday == 5)
                    Console.WriteLine("Пятница");
                    else if (Nday == 6)
                        Console.WriteLine("Суббота");
                        else if (Nday == 7)
                            Console.WriteLine("Воскресенье");