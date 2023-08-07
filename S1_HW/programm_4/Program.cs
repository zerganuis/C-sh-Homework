// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое целое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе целое число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье целое число: ");
int thirdNumber = int.Parse(Console.ReadLine()!);
int max=0;
if(firstNumber<secondNumber)
{
max=secondNumber;
}
if(firstNumber<thirdNumber)
{
max=thirdNumber;
}
if(firstNumber>thirdNumber)
{
    max=firstNumber;
}

Console.WriteLine($"Максимальное число равно {max}");