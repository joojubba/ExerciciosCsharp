/*
 *  Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
O programa deve exibir se a hora digitada está ou não válida. 
Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
 * */

int hora, min;

Console.WriteLine("Informe a hora: ");
string[] horario = Console.ReadLine().Split(':');
hora = int.Parse(horario[0]);
min = int.Parse(horario[1]);

if(hora >= 0 && hora <= 23)
{
    if(min >= 0 && min <= 59)
    {
        Console.WriteLine("Hora digitada está válida.");
    }
    else
    {
        Console.WriteLine("Hora digitada não válida.");
    }

}
else
{
    Console.WriteLine("Hora digitada não válida.");
}

