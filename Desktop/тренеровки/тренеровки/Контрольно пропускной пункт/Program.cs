// Контрольно пропускной пункт.

// M:
// Console.WriteLine("Контрольно пропускной пункт грузовых авто ");
// int avto = Convert.ToInt32(Console.ReadLine());

// int cargo = 0;
// int passenger = 0;
// int mass = 2000;

// if(mass < avto)
// {
//     cargo++;
//     Console.WriteLine("Грузовое авто " + cargo);
//     goto M;
// }
// else if(mass > avto)
// {
//     passenger++;
//     Console.WriteLine("Легковое авто " + passenger);
//     goto M;
// }

M:
Console.WriteLine("Контрольно пропускной пункт грузовых авто ");
int avto = Convert.ToInt32(Console.ReadLine());

int cargo = 0;
int passenger = 0;
int mass = 2000;

if(mass < avto)
{
    cargo++;
    Console.WriteLine("Грузовое авто " + cargo);
}
else
{
    passenger++;
    Console.WriteLine("Легковое авто " + passenger);
}
goto M;