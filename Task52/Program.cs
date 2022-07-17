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
            new2dArray[i, j] = (new Random().Next(1, 10));

    return new2dArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");

        Console.WriteLine();
    }
}

void Average(double[,] twodarray)
{

    for (int l = 0; l < twodarray.GetLength(1); l++)
    {
        double sum = 0;
        for (int k = 0; k < twodarray.GetLength(0); k++)
        {
            sum = sum + twodarray[k, l];
        }
        double average = sum / twodarray.GetLength(0);
        average = Math.Round(average, 1);
        Console.WriteLine("Среднее арифметическое " + $"{l+1}" + " столбца: " + average);
    }
}

int m = new Random().Next(3, 11);
int n = new Random().Next(3, 11);

double[,] my2dArray = Random2dArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);

Average(my2dArray);