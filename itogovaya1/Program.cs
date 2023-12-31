﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void ArrayFilter (string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine("Результат фильтрации:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

void Main()
{
    Console.WriteLine("Введите массив строк, разделенных пробелами:");
    string input = Console.ReadLine();
    string[] array1 = input.Split(' ');

    string[] array2 = new string[array1.Length];
    ArrayFilter(array1, array2);
    PrintArray(array2);
}

Main();
