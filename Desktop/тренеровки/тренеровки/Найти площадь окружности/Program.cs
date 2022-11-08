// Найти площадь окружности с заданным диаметром.

Console.WriteLine("Задайте диаметр окружности для нахождения площади ");
double d = Convert.ToDouble(Console.ReadLine());

double S = 0.0;
double pi = 3.14;

if(S < d)
{
    S = ((d * d) / 4) * pi;
    Console.WriteLine("Площадь окружности = " + S);
}