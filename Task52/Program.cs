// 1. Задайте двумерный массив из целых чисел. 
// 2. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк массива: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(numberA, numberB, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
double[] array3d = AverageValueElements(array2d);
PrintArray(array3d);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

double[] AverageValueElements(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] newArr = new double[size];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result = result + matrix [i, j];
        }
        newArr[j] = Math.Round(result / matrix.GetLength(0), 1);
    }
    return newArr;
}

void PrintArray(double[] arr)
{
    Console.Write("Среднее арифметическое значение в каждом столбце: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}