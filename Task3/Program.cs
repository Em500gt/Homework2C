using static System.Console;
Clear();

//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Write("Введите день недели: ");
int number = int.Parse(ReadLine()!);
if (number < 1 || number > 7)
{
    Write("Вы ввели не верное число!!!");
    return;
}
else
{
    Write(number == 6 || number == 7? "Да": "Нет");
}
