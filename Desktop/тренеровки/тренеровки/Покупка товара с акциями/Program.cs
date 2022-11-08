// Покупка товара с акциями. Если стоимость больше 1000р скидка 20%. Если заказ более чем 700р доставка бесплатно
M:
Console.Clear();

Console.WriteLine("Задайте сумму покупки и программа посчитает доставку или скидку ");
double sum = Convert.ToDouble(Console.ReadLine());

// skidka = (80.0 / 100.0)* 20.0;

double discount = 1000.0;
double delivery = 700.0;
double skidka = 0.0;
double result = 0.0;
double clear = 0.0;

if(sum <= clear)
{
    Console.WriteLine("Вы нечего не купили, заходите к нам ещё ");
    Console.Clear();
    goto M;
}
else if(discount <= sum)
{
    skidka = (sum / 100) * 20;
    result = sum - skidka;
    Console.WriteLine("При покупке товаров ваша скидка составила " + skidka + "руб + наша доставка.");
    Console.WriteLine("К оплате " + result + "руб");
}
else if (sum >= delivery)
{
    Console.WriteLine("К оплате " + sum + "руб + наша доставка.");
}
else if (sum < delivery)
{
    Console.WriteLine("К оплате " + sum + "руб");
}