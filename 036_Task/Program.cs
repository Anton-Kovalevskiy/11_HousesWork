/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

// Решение

int Parameters (string message)         // метод задания параметров массива
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return (result);
}

int [] FillPrintArray (int size)        // метод заполнения и вывода на экран массива
{
    int [] array = new int [size];
    Console.WriteLine("Получен массив:");
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(-99,100);
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
    return (array);
}

int SummOddPosition (int [] array)      // метод нахождения суммы элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

int size = Parameters("Введите количество элементов массива: ");
int [] array = FillPrintArray(size);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SummOddPosition(array)}"); 