using static System.Console;
Clear();
//Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
WriteLine(number / 10 % 10);
