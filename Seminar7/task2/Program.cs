// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет


int pos1 = InputeNum();
int pos2 = InputeNum();

int n = 5;
int m = 7;
int[,] arr = Create2dArr(n, m);
PrintAnser();

int[,] Create2dArr(int n, int m)
{
    Random random = new Random();
    int[,] arr = new int[n, m];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(10, 99);
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
    return arr;
}

void PrintAnser()
{
    if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует  ");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
    }    
}

int InputeNum()
{
    Console.WriteLine("Введите строку, столбец:  ");
    bool uinput = int.TryParse(Console.ReadLine(), out int num);
    if (uinput)
    {
        return num -1;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}