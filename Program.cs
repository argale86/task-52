//Найти среднеарифметическое в столбцах массива
Console.WriteLine("Введите кол-во элементов по горизонтали в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов по вертикали в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
float [ , ] mas = new float [m,n];
Random rnd = new Random();
for (int count1 = 0; count1 < m; count1++)
{
    for (int count2 = 0; count2 < n; count2++)
    {
        mas[count1,count2] = rnd.Next(-15, 15);
        Console.Write(" " + mas[count1,count2] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Среднеарифметические значения по столбцам:");
int m1 = mas.GetUpperBound(0) + 1;
int n1 = mas.Length / m1;
float sum = 0;
float srarif = 0;
for (int count3 = 0; count3 < n1; count3++)
{
    for (int count4 = 0; count4 < m1; count4++)
    {
        sum = sum + mas[count4,count3];
    }
    srarif = sum / m1;
    Console.Write(" " + srarif);
    sum = 0;
}
Console.WriteLine();
