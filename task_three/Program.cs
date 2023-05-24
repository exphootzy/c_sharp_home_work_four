// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int Start(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int [] FillArray(int lenght, int numMin, int numMax)
{
    int [] array = new int[lenght];
    Random random = new Random ();
    for (int i = 0; i < lenght; i++)
    {
        array [i] = random.Next(numMin, numMax +1);
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

int lenght = Start("Размер массива: ");
int minNum = Start("Минимальное значение для рандомного заполнения массива: ");
int maxNum = Start("Максимальное значение для рандомного заполнения массива: ");
int [] array = FillArray(lenght, minNum, maxNum);
PrintArray(array);






    