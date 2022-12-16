//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int n = InputeNum();
int m = InputeNum();
int[,] arr1 = Create2dArr(n, m);
int[,] arr2 = Create2dArr(n, m);
int SumTwoArr = SumArr(arr1, arr2);
Console.WriteLine($" Средне арифметическое дву двумерных массивов = {SumTwoArr/ arr1.GetLength(0)}");

int SumArr(int[,] a1, int[,] a2)
{
    int sum=0;
    for (int i = 0; i < a1.GetLength(0); i++)
    {
        for (int j = 0; j < a1.GetLength(1); j++)
        {
            sum+= a1[i, j];            
        }
    }    
    for (int i = 0; i < a2.GetLength(0); i++)
    {
        for (int j = 0; j < a2.GetLength(1); j++)
        {
            sum+= a2[i, j];            
        }        
    }
    return sum;
}


int[,] Create2dArr(int n, int m)
{
    Random random = new Random();
    int[,] arr = new int[n, m];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 11);
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
    return arr;
}
int InputeNum()
{
    Console.WriteLine("Введите строку, столбец:  ");
    bool uinput = int.TryParse(Console.ReadLine(), out int num);
    if (uinput)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

/* Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
} */