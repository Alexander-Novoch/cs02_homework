//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using System;

Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());

int remains = number;
int score = 0;

if (number / 100 == 0)
    Console.WriteLine("третьей цифры нет");
else {
    while (remains > 0) {
        remains = remains / 10;
        score = score + 1;
    }
    int[] array1 = new int[score];

    for (int i = 0; i < score; i++ )
        {
            array1[i] = number % 10;
            number = number / 10;
        } 
    score = score - 3;
    Console.WriteLine(array1[score]);
    
}
