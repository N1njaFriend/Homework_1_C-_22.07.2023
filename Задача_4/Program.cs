// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число A :");
int numA =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B :");
int numB =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C :");
int numC =Convert.ToInt32(Console.ReadLine());

if(numA>numB)
{
    Console.Write("Ваше число A : "); Console.WriteLine(numA);
}
else if(numB>numC)
{
    Console.Write("Ваше число B : "); Console.WriteLine(numB);
}
else if(numC>numA)
{
    Console.Write("Ваше число C : "); Console.WriteLine(numC);
}
else if(numA>numC)
{
    Console.Write("Ваше число A : "); Console.WriteLine(numA);
}
else if(numB>numA)
{
    Console.Write("Ваше число B : "); Console.WriteLine(numB);
}
else if(numC>numB)
{
    Console.Write("Ваше число C : "); Console.WriteLine(numC);
}