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

/* //Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.

int[,] a = new int[5, 6];
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i,j]=i+j;
        Console.Write($" {a[i,j]}");
    }
    Console.WriteLine();
} */

//Задача 53: В двумерном массиве показать позиции числа, заданного пользователем

int[,]myArr = new int[4, 5];
for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        myArr[i,j]=new Random().Next(10,99);
        Console.Write($" {myArr[i,j]}");
    }
    Console.WriteLine();
} 
Console.WriteLine("Введите искомое число");
int x=int.Parse(Console.ReadLine());

for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        if(myArr[i,j]==x)
        {
            Console.WriteLine($"В массиве присутствует искомое число, индекс: "+i+";"+j); 
        }
    }
        
} 
 

/* //Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,]myArr = new int[3, 4];
int x=0;
for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        myArr[i,j]=new Random().Next(1,100);
        Console.Write($" {myArr[i,j]}");
    }
    Console.WriteLine();
}
for (int i = 0; i < myArr.GetLength(1) ; i++)
{
    for (int j = 0; j < myArr.GetLength(0); j++)
    {
        x+=myArr[j,i];
    }
    Console.WriteLine((double)x/myArr.GetLength(0));
} */

