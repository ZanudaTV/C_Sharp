/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

test

456 -> 5
782 -> 8
918 -> 1 */


int md (int num)
{
    if (num >= 0){
        return num;
    } else {
        return (num * (-1));
    }
}

Console.Write("Введите целое трех значное число ");

bool isInt = int.TryParse(Console.ReadLine(), out int num);
num = md(num);
if (!isInt)
{
    Console.WriteLine("Это не целое число");
} 
else if (num <= 999 && num > 99)
{
    Console.WriteLine("Ответ ");
}

int first = num / 100;
int second = ((num - first*100) / 10);

Console.WriteLine(second);
