// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double [] columnAverage(int[,] massive)
{
    double[] averege = new double[massive.GetLength(1)];
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            averege[j] = averege[j] + massive[i, j];
        }
        averege[j] = averege[j] / massive.GetLength(0);
    }
    return averege;
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInfo("Введите количество строк массива ");
int m = GetInfo("Введите количество столбцов массива ");
int[,] massive = new int[n, m];
FillArray(massive);
PrintArray(massive);
double [] averege = columnAverage(massive);
Console.Write($" Среднее арифметическое столбцов: " + string.Join("; ", averege));
