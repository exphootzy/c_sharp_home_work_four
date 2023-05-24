// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Start(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SummAllElements(int num)
{
    int summ = 0;
    while (num > 0)
    {
        summ = summ + num % 10;
        num = num / 10;
    }
    return summ;
}

int num = Start("Введите число, сумма элементов которого будет найдета: ");
System.Console.WriteLine($"Сумма элекмтнов числа {num} равна: {SummAllElements(num)}");