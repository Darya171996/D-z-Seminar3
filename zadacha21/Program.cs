//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("Введите ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите az: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите by: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
Console.Write(Math.Round (result, 2 ));