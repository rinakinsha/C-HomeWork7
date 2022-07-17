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

void ElementValue(double[,] array, int c, int d)
{
    int row = c;
    int column = d;

    if (row >= 0 && row < array.GetLength(0))
    {
        if (column >= 0 && column < array.GetLength(1))
        {
            Console.Write("Значение указанного элемента: " + array[row, column]);
        }
        else Console.Write("Такого элемента нет (ошибка в указании столбца).");
    }
    else Console.Write("Такого элемента нет (ошибка в указании строки).");
}

int m = new Random().Next(3, 11);
int n = new Random().Next(3, 11);

double[,] my2dArray = Random2dArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);

Console.Write("Введите позицию искомого элемента (помните, что счет начинается с 0!): строка - ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("                                                                       столбец - ");
int c = Convert.ToInt32(Console.ReadLine());

ElementValue(my2dArray, r, c);