﻿//нахождение индекса заданного числа
// index =       0     1   2  3   4   5   6   7   8
int[] array = { 111, 223, 33, 4, 81, 54, 66, 75, 81 };

int n = array.Length;
int find = 81;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}