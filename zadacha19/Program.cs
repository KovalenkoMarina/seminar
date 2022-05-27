// Показать двумерный массив размером m×n заполненный целыми числами
// В двумерном массиве n×k заменить четные элементы на противоположные

Console.Write("Введите число m ");
int m = int.Parse(Console.ReadLine()?? "");

Console.Write("Введите число n ");
int n = int.Parse(Console.ReadLine()?? "");

void PrintArray(int [,] matr)
{
    for (int m = 0; m <matr.GetLength(0); m++)
    {
        for(int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
    Console.WriteLine();
    }
}
void FillArray (int [,] matr)
{
    for (int m = 0; m <matr.GetLength(0); m++)
    {
        for(int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(1,10);
        }
    
    }
}
int[,] matrix = new int[m, n];


FillArray(matrix);
PrintArray(matrix);