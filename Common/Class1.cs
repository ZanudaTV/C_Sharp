namespace Common;

public static class Class1
{
   static int[] CreateArray()
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
}
