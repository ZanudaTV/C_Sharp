/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int InputInt()
{
    Console.WriteLine("Введите число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

int num = InputInt();

int[] GetCubeTable (int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = (int)((Math.Pow(i + 1, 3)));
    }
    return array;    
}

int[] cubeTable = GetCubeTable(num);

void PrintArray (int[] arr)
{
    for (int i =0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

PrintArray(cubeTable);