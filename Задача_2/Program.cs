﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число A : ");
int numA =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B : ");
int numB =Convert.ToInt32(Console.ReadLine());

if(numA>numB)
{
    Console.Write("Число A больше, числа B : "); Console.WriteLine(numA);
}
else if(numA<numB)
{
    Console.Write("Число B больше, числа A : "); Console.WriteLine(numB);
}
else
{
    Console.Write("Числа равны!");
}
