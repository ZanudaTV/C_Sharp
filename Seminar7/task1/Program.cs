// . Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


using static Common.Class1;

double[,] resalt = CreateRan2DArrayDuable(3, 4);
Print2DArray(resalt);


double[,] CreateRan2DArrayDuable(int m, int n)
{
    Random random = new Random();
    double[,] array = new double[m, n];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = /* random.Next(10, 11) */ i * j + Math.Round(random.NextDouble(), 1);
        }
    }
    return array;
}


