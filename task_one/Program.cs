
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Start(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Exponentiation(int num, int degree)
{
    int result_exp = 1;
    for (int i = 0; i < degree; i++)
    {
        result_exp = result_exp * num;
    }
    return result_exp;
}

bool Check(int degree)
{
    if (degree < 0)
    {
        System.Console.WriteLine("Степень числа должна быть больше 0");
        return false;
    }
    return true;
}

int num = Start("Введите число которое будем возводить в степень: ");
int degree = Start("Введите степень в которую будем возводить число: ");
if (Check(degree))
{
    System.Console.WriteLine($"Число {num} в степени {degree} равно: {Exponentiation(num, degree)}");
}


