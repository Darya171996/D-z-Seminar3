//Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



Console.WriteLine("Веедите число: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
for (int i = 0; i < N; i++)
{
    // array[i] = (i + 1) * (i + 1) * (i + 1);
    array[i] = Math.Pow(i + 1, 3);
    Console.WriteLine($"{array[i]}");
}

