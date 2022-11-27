/* Задача 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите колличество элементов массива:\t");

int elements = int.Parse(Console.ReadLine());

int[] array = new int[elements];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i}:\t");
    array[i] = int.Parse(Console.ReadLine());
}

Console.Write("Максимальное число: ");
Console.Write(array.Max());