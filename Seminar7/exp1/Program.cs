// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4. 0 1 23

using static Common.Class1;

int[,] resalt = CreateArreyFormul(3, 4);
Print2DArray(resalt);




int[,] CreateArreyFormul(int m, int n)
{
    int[,] array = new int[m,n];

      for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = i + j;
            }
        }
        return array;
}