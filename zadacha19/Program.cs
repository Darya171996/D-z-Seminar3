// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да
Console.WriteLine("Веедите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 10000;
Console.WriteLine(num1);
int num2 = (num / 1000) % 10;
int num4 =  (num / 10) % 10;
int num5 = num % 10;
if (num1==num5 && num2==num4) 
Console.WriteLine("да");
else 
Console.WriteLine("нет");