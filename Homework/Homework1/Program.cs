//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int reversA = numberA % 10;
int remeberA = numberA;
while (numberA / 10 > 0)

{
    reversA = reversA * 10 + numberA / 10 % 10;
    numberA = numberA / 10;
}
if (remeberA == reversA)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}