try
{
    Console.Write("Введите x:");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    double P = 1;
    double S = 0;
    for (int k = 1; k <= n; k++)
    {
        if (k != 2) S += Math.Pow(-3, 3 * k + 1) / (k - 2) * Math.Pow(x, 3 * k + 1);
        for (int m = 1; m <= k + n; m++)
        {
            if (m != 11) P *= m * m * m - 8 / m - 3;
        }
    }
   
    Console.WriteLine($"S={P * S:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}





