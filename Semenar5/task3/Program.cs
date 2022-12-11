// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Не использовать готовые методы Min и Max [3 7 22 2 78] -> 76


int[] array = CreatRandomArray();
PrintArray(array);

array = arrSort(array);
PrintArray(array);

int resalt = array[4] - array[0];
Console.WriteLine($" разница составит {resalt}");

int[] arrSort(int[] array)
{
    Array.Sort(array);
    if (array.Length > 0)
    {
        Console.WriteLine("Minimum number is " + array[0]);
        Console.WriteLine("Maximum number is " + array[array.Length - 1]);
    }
    return array;
}

int[] CreatRandomArray()
{
    Random random = new Random();

    int[] array = new int[5];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
}

