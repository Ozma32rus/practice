// Найти площадь прямоугольника с заданными сторонами height и width

Console.WriteLine("Введите стороны прямоугольника для расчёта площади ");
double height = Convert.ToDouble(Console.ReadLine());
double width = Convert.ToDouble(Console.ReadLine());

double result = 0.0;

if(result < height)
{
    result = height * width;
    Console.WriteLine("Площадь прямоугольника = " + result);
}