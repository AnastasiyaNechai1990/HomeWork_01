//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);
int max = number1;

if (number1<number2)
{
    max = number2;
}
else
{
     max = number1;
}
if (number2>number3)
{
    max = number2;   
}
else
{
    max = number3;   
}
if (number1>number3)
{
    max = number1;
}
else
{
    max = number3;
}
Console.WriteLine($"max={max}");