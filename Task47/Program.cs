double[,] Random2dArray(int a, int b)
{
    while (a <= 0)
    {
        Console.Write("Невозможно построить двумерный массив с заданным количеством строк. Пожалуйста, повторите попытку: ");
        a = Convert.ToInt32(Console.ReadLine());
    }

    while (b <= 0)
    {
        Console.Write("Невозможно построить двумерный массив с заданным количеством столбцов. Пожалуйста, повторите попытку: ");
        b = Convert.ToInt32(Console.ReadLine());
    }
    
    double[,] new2dArray = new double[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = (new Random().Next(-10, 11)) + new Random().NextDouble();

    return new2dArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(array[i, j], 1);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в двумерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] my2dArray = Random2dArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);
