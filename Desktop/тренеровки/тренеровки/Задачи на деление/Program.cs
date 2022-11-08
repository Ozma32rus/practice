// Задачи на деление. Дано 2809 секунд сколько это минут?

Console.WriteLine("Дано 2809 секунд сколько это минут? ");

double sek = 2809.0;
double min = 60.0;

if(sek > min )
{
    min = sek / min;
    Console.WriteLine("Результат вычеслений составил " + min);
}