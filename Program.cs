//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] ArrayA (int row, int column, int min, int max)
{
    double[,] array = new double[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            array[i, j] += new Random().NextDouble(); 
        }
    return array;
}

void ArrayRandomNum (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j] < 0 ? "": " ") + Math.Round(array[i, j], 1) + "\t");
        Console.Write("\n");
    }
}

Console.Write("Input number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal integer value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal integer value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] ArrayB = ArrayA(row, column, min, max);
ArrayRandomNum(ArrayB);
*/
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
/*
 double[,] FillArray()
{
Console.WriteLine("Input quality of rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input qualityof columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value = ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value = ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columns];
for(int i = 0; i<rows; i++)
{
for(int j = 0; j<columns; j++)
{
array[i,j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
}
}
return array;
}
void ShowArray(double[,] array)
{
for(int i=0; i<array.GetLength(0); i++)
{
for(int j=0; j<array.GetLength(1); j++)
{
Console.Write($"{Math.Round(array[i,j],2)} ");
}
Console.WriteLine();
}
Console.WriteLine();
}
void PositionElement(double[,] array, int row, int column)
{
if(row > array.GetLength(0)&& column > array.GetLength(1))
{
Console.WriteLine("Такого элемента в массиве нет");
}
else 
{
Console.WriteLine($" {Math.Round(array[row, column],2)} ");
}
}

Console.WriteLine("Input number of row = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of column = ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] newRandomArray = FillArray();
ShowArray(newRandomArray);
PositionElement(newRandomArray, row, column);
*/
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] FillArray()
{
Console.WriteLine("Input quality of rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input qualityof columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value = ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value = ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
for(int i = 0; i<rows; i++)
{
for(int j = 0; j<columns; j++)
{
array[i,j] = new Random().Next(minValue, maxValue);
}
}
return array;
}

void ShowArray(int[,] array)
{
for(int i=0; i<array.GetLength(0); i++)
{
for(int j=0; j<array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
Console.WriteLine();
}

double[] AverageOfColumnArray(int[,] array)
{
double[] averageColumnElement = new double[array.GetLength(1)];
for(int j = 0; j<array.GetLength(1); j++)
{ 
double[] average = new double[array.GetLength(1)]; 
for(int i = 0; i<array.GetLength(0); i++)
{
average[j]+= array[i,j];
}
averageColumnElement[j] = average[j]/(array.GetLength(0));
}
return averageColumnElement;
}

void PrintArray(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write($" {array[i]} ");
}
Console.WriteLine();
}

int[,] newRandomArray = FillArray();
ShowArray(newRandomArray);
double[] averageColumnElement = AverageOfColumnArray(newRandomArray);
PrintArray(averageColumnElement);
*/