double k1 = InputValue("Введите первый числовой коэффициент для первой точки");
double b1 = InputValue("Введите второй числовой коэффициент для первой точки");
double k2 = InputValue("Введите первый числовой коэффициент для второй точки");
double b2 = InputValue("Введите второй числовой коэффициент для второй точки");
double X = FindX (b2, b1, k1, k2);
double Y = FindY (k1, X, b1);
Console.Write($"Координаты точки пересечения двух прямых: [{X}; {Y}]");


double InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    double a = double.Parse(value);
    return a;
}

double FindX (double a2, double a1, double c1, double c2)
{
    double X = (a2-a1)/(c1-c2);
    return X;
}

double FindY (double c1, double N, double a1)
{
    double Y = (c1 * N) + a1;
    return Y;
}

