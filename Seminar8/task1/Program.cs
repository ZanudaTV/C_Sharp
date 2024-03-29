﻿/* Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив: */

using task1;


MyGenerate gen = new MyGenerate();

int[,] myArr = gen.ArrayGenDI();
MyMethod.Print(myArr);

int[,] sortByRaw = SortedArrayByRaw(myArr);
MyMethod.Print(sortByRaw);

int[,] SortedArrayByRaw(int[,] usersArray)
{
    int[,] editedArray = new int[usersArray.GetLength(0), usersArray.GetLength(1)];
    for (int i = 0; i < usersArray.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < usersArray.GetLength(1) - 1; j++)
        {
            if (usersArray[i, j] < usersArray[i, j + 1])
            {
                temp = usersArray[i, j + 1];
                usersArray[i, j + 1] = usersArray[i, j];
                usersArray[i, j] = temp;
                j = 0;
                j--;
            }
        }
    }

    return usersArray;
}