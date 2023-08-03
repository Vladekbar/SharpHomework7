// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Сначала делаем для определенного числа

// для того, чтобы пройтись по всему массиву нужно взять от i до j
// далее нам нужно либо найти позицию с индексами [1,7] тогда мы объявляем эти позиции в функции(массив+индекс 1 и индекс 2)
// Либо нам нужен конкретный элемент массива 

string Text(string text)
{
    if (text != string.Empty)
    {
        return text;
    }
    else return "не найдены. Число отсутствует в массиве";
}

string SearchDigital(int[,] massive, int digit)
{
    string text = string.Empty;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (massive[i, j] == digit)
            {
                text = text + "[" + i + "," + j + "]" + ";";

            }
        }
    }
    return text;
}

void PrintDoubleMassive(int[,] massive)
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

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] massive = DoDoubleMassive(4, 5, -10, 11);
PrintDoubleMassive(massive);
int digital = GetInfo($"Введите число, которое необходимо найти в массиве ");
string result = Text(SearchDigital(massive, digital));
Console.Write($"Координаты числа {digital}: {result}");