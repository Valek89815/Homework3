//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в
// 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите число x1");
int numberx1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число y1");
int numbery1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число z1");
int numberz1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число x2");
int numberx2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число y2");
int numbery2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число z2");
int numberz2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((numberx2 - numberx1) * (numberx2 - numberx1) + (numbery2 - numbery1) * (numbery2 - numbery1) + (numberz2 - numberz1) * (numberz2 - numberz1));
result = Math.Round(result,2);  // Это округление до двух знаков после запятой.
Console.Write(result);

