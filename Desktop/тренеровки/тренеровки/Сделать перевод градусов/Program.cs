// Сделать перевод градусов цельсия в градусы фаренгейта

Console.WriteLine("Задайте число градусов цельсия или фаренгейта ");
double c = Convert.ToDouble(Console.ReadLine());
double f = Convert.ToDouble(Console.ReadLine());

double result = 0;

if(result < c)
{
    result = c * 1.8 + 32;
    Console.WriteLine("Результат перевода градусов цельсия в градусы фаренгейта составил " + result);
}
else
{
    result = (f - 32) / 1.8;
    Console.WriteLine("Результат перевода градусов фаренгейта в градусы цельсия составил " + result);
}

