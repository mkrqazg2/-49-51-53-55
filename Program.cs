//Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.
/* void PrintArray(double[,] matr)
{
for (double i = 0; i < matr.GetLength(0); i++)
{
for (double j = 0; j < matr.GetLength(1); j++)
{
Console.Write($" {matr[i, j]}");
}
Console.WriteLine();
}
}

void FillArray(double[,] matr)
{
for (double i = 0; i < matr.GetLength(0); i++)
{
for (double j = 0; j < matr.GetLength(1); j++)
{
matr[i, j] = new RandomDouble().Next(1, 100) ; // заполняем числами [0,100)
}
}
}
Console.WriteLine("Введите количество строк ");
double m = double.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
double n = double.Parse(Console.ReadLine());
double[,] array = new double[m,n];  // m это строки; n столбцы
FillArray(array);
PrintArray(array); */

double[,] a = new double[5, 10];

Random random = new Random();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.NextDouble() * 1; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}