// Найти периметр квадрата с заданной стороной side.

Console.Write("Привет, уточни сторону квадрата -> ");
double side = Convert.ToDouble(Console.ReadLine());

double result = 0.0;

if(result < side)
{
    result = side * 4;
    Console.WriteLine("Периметр квадрата = " + result);
}
