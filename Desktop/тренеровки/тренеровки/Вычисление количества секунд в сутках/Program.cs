// Вычисление количества секунд в сутках

Console.WriteLine("Укажите количество часов в которых нужно вычеслить сколько в них секунд ");
int day = Convert.ToInt32(Console.ReadLine());

int sek = 1;
int min = 60;
if(sek <= day)
{
    day = day * (min * (sek * 60));
    Console.WriteLine("В указаных пользователем часах " + day + " секунд");
}