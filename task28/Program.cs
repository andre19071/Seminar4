﻿// Задача 28: Напишите программу, которая принимает на вход
//  число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int res = 1;
// int i;

// for (i = 1; i <= N; i++)
// {
//     res = res * i;
// }
// Console.WriteLine(res);


Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int fact = 1;

if ( N>=1 )
{
    for (int i = 1; i<=N; i++)
    {
        fact = fact * i;
    }
    Console.WriteLine(fact);
}
else
{
    Console.WriteLine("Введено некорректное число");
}