// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}


Console.WriteLine("Ведите число: ");
int num = int.Parse(Console.ReadLine());

int CetArr(int[,] parray)
{
    int min = 0; //минимальная позиция в массиве
    int max = m * n - 1; // максимальная позиция в массиве

    while (true)
        if (num >= min && num <= max)
        {
            Console.Write("->" + parray[num/m, num%n]);
        }
        else
        {
            Console.Write($"{num} -> такого числа нет");
           
        }
   

}


int[,] arrayResult = GetArray(m, n);
PrintArray(arrayResult);
Console.WriteLine();
Console.WriteLine(CetArr(arrayResult));
