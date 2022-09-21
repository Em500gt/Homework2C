using static System.Console;
Clear();
//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int result = number / 100 % 10;
WriteLine(result == 0? "Третьей цифры нету": result);