/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */



int InputInt(){
        Console.WriteLine("Введите число ");
        bool uinput = int.TryParse(Console.ReadLine(),  out int num);
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
    int num = InputInt();
    int newnum = 0;
        for (int i = num; i > 0; i = (i / 10))
        {
            int remainder = i % 10;
            
            newnum = (newnum * 10) + remainder;
        }

        if (newnum == num)
        {
            Console.Write($"Число {newnum} является полидромом числа {num}");
        }
        else
        {
            Console.WriteLine($"Число {newnum} не является полидромом числу {num}");
        }
        