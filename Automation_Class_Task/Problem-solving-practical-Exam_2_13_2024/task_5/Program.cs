﻿// 5.	Введите массив из 12 элементов определенного типа.
// Определите сумму четных элементов по индексу и произведение нечетных элементов по значению.

// произведение чисел это результат их умножение

int[] arr = new int[12] { 2, 8, 5, 10, 1, 7, 2, 0, 9, 8, 7, 3 };

int size = arr.Length;

// (Сумма) Четное число это 2, 4, 6 ... делятся на 2 и ровняются на 0
int even_sum = 0;

// (Произведение) Нечетное число это 1, 3, 5 ... делятся на 2 и не ровняются на 0
// произведение это умножение, а умножение не может умножено на 0
int odd_product = 1;



foreach (int num in arr)
{
    if (num % 2 == 0) // even
    {
        even_sum += num;
    }
    else // odd
    {
        odd_product *= num;
    }
}


Console.WriteLine("Сумма четных: " + even_sum);
Console.WriteLine("Произведение нечетных: " + odd_product);
