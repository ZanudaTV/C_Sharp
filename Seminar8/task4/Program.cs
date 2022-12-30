/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

using Seminar8;

MyGenerate gen = new MyGenerate();
Random rnd = new Random();

int[,,] myArr = ArrayGenTI();
Print(myArr);


int[,,] ArrayGenTI()
    {
        int rows = MyMethod.IntInput("число строк");
        int columns = MyMethod.IntInput("число столбцов");
        int depth = MyMethod.IntInput("глубина массива");
        int min = 10;
        int max = 99;
        int element = rnd.Next(min,max);
        int[,,] array = new int[rows, columns, depth];
        for (int i = 0; i < rows; i++)
        {
            for (int j= 0; j < columns; j++){
                for (int k= 0; k < depth; k++){
                    while (!(unicumInArr(array, element))){
                        element = rnd.Next(min,max);
                    }
                    array[i,j,k] = element;
                }
            }  
        }
        
        return array;
    }

    bool unicumInArr (int[,,] usersArray, int num){
        for (int i = 0; i < usersArray.GetLength(0); i++)
        {
            for (int j= 0; j < usersArray.GetLength(1); j++){
                for (int k= 0; k < usersArray.GetLength(2); k++){
                    if (usersArray[i,j,k] == num) return false;
                }
            }  
        }
        return true;
    }

    void Print (int[,,] usersArray){
        for (int i = 0; i < usersArray.GetLength(0); i++)
        {
            for (int j= 0; j < usersArray.GetLength(1); j++){
                for (int k= 0; k < usersArray.GetLength(2); k++){
                    Console.Write($"| {usersArray[i,j,k]} ({i},{j},{k}) |");
                }
                Console.WriteLine();
            }
            Console.WriteLine();  
        }
        Console.WriteLine();
    }