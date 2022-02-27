/* //Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.

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
} */

//Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.

int[,] a = new int[5, 6];
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=i+j;
        Console.Write($" {a[i,j]}");
    }
    Console.WriteLine();
}