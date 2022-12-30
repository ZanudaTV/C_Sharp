/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

using Seminar8;

MyGenerate gen = new MyGenerate();


int[,] matrix1 = gen.ArrayGenDI();
MyMethod.Print(matrix1);
int[,] matrix2 = gen.ArrayGenDI();

int[,] productMatrix = MatrixProduct(matrix1,matrix2);
MyMethod.Print(" -----------");
MyMethod.Print(matrix1);
MyMethod.Print("      *     ");
MyMethod.Print(matrix2);
MyMethod.Print(" ===========");
MyMethod.Print(productMatrix);

int[,] MatrixProduct (int[,] matrix1, int[,] matrix2){
    int[,] product = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    MyMethod.Print("arr created");
    for (int i=0; i<product.GetLength(0); i++){

        for (int j=0; j<matrix1.GetLength(1); j++){

            for (int k=0; k<matrix2.GetLength(0); k++){

                product[i,j]+= matrix1[i,j]*matrix2[k,i];

            }
        }
    }
    return product;
}