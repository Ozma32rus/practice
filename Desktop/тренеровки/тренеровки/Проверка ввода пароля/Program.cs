// Проверка ввода пароля.
// пароль gfhjkm12345


Console.WriteLine("Задайте пароль для его проверки ");
string? pass = Convert.ToString(Console.ReadLine());

string result = "gfhjkm123";

if(result == pass)
{
    Console.WriteLine("Пароль верен ");
}
else
{
    Console.WriteLine("Вы забыли пароль, попробуйте снова ");
}