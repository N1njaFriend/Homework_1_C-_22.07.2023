// Console.WriteLine("Hello, World!");

// Console.WriteLine("Введите число:");
// int num =Convert.ToInt32(Console.ReadLine());

// int result = num*num;

// Console.WriteLine(result);

// 1. Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите число:");
// int num1 =Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число:");
// int num2 =Convert.ToInt32(Console.ReadLine());

// if(num1==num2*num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Console.WriteLine("Введите число:");
// int num1 =Convert.ToInt32(Console.ReadLine());

// if(num1==1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(num1==2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(num1==3)
// {
//     Console.WriteLine("Среда");
// }
// else if(num1==4)
// {
//     Console.WriteLine("Четверг");
// }
// else if(num1==5)
// {
//     Console.WriteLine("Пятница");
// }
// else if(num1==6)
// {
//     Console.WriteLine("Суббота");
// }
// else if(num1==7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня недели нет");
// }

// 5. Напишите программу, которая на вход принимает
//  одно число (N), а на выходе показывает все целые
//   числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число:");
// int num1 =Convert.ToInt32(Console.ReadLine());

// int newNeg=num1*-1;

// while(newNeg<=num1)
// {
//     Console.WriteLine(newNeg);
//     newNeg=newNeg+1;
// }

// 7. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

// 	456 -> 6
// 782 -> 2
// 918 -> 8   %

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32 (Console.ReadLine());

// int result= num1%10;

// Console.WriteLine(result);

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число A");
int numA =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numB =Convert.ToInt32(Console.ReadLine());

if(numA>numB)
{
    Console.Write("Ваше число A : "); Console.WriteLine(numA);
}
else
{
    Console.Write("Ваше число B : "); Console.WriteLine(numB);
}



// Задача 4

// Console.WriteLine("Введите число A");
// int numA =Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B");
// int numB =Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число C");
// int numC =Convert.ToInt32(Console.ReadLine());

// if(numA>numB)
// {
//     Console.Write("Ваше число A : "); Console.WriteLine(numA);
// }
// else if(numB>numC)
// {
//     Console.Write("Ваше число B : "); Console.WriteLine(numB);
// }
// else if(numC>numA)
// {
//     Console.Write("Ваше число C : "); Console.WriteLine(numC);
// }
// else if(numA>numC)
// {
//     Console.Write("Ваше число A : "); Console.WriteLine(numA);
// }
// else if(numB>numA)
// {
//     Console.Write("Ваше число B : "); Console.WriteLine(numB);
// }
// else if(numC>numB)
// {
//     Console.Write("Ваше число C : "); Console.WriteLine(numC);
// }