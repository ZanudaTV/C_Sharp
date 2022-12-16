namespace Common;

public static class Class1
{
    public static int[] CreateArray()
    {
        Console.Write("Введите колличество элементов массива:\t");  // запутался в типах данных пытался
                                                                    // все до вывода в коноль в метод но не выходило из за int[] не преобразовывается в int.
                                                                    // в чем разница помню но решить не вышло.

        int elements = int.Parse(Console.ReadLine());

        int[] array = new int[elements];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\n Введите элемент массива под индексом {i}:\t");
            array[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("[{0}]", string.Join(", ", array));
        return array;
    }


    public static int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
    {
        Random random = new Random();
        int[,] array = new int[countOfRows, countOfColumns];

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-10, 11);
            }
        }
        return array;
    }

    public static void Print2DArray(double[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}