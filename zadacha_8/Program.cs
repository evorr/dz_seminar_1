﻿// Напишите программу, которая на вход принимает число (N), а на 
//выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num>1)
{
   int i=2;
   while (i<=num)
     {
    Console.WriteLine(i);
    i=i+2;
     }
}
else
{
    int i = 0;
    while (i>=num)
    {
        Console.WriteLine(i);
        i=i-2;
    }
}
