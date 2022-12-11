// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] => 2
int InputeSize()
{
    Console.WriteLine("Введите размер массива:   ");
    bool uinput = int.TryParse(Console.ReadLine(), out int size);
    if (uinput)
    {
        return size;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}
int size = InputeSize();
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = evenNumbersArray();
int evenNumbersArray()
{
    int count = 0;

    for (int z = 0; z < numbers.Length; z++)
        if (numbers[z] % 2 == 0)
            count++;
    return count;
}
Console.WriteLine($"всего в массиве {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}