/*Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto.
 * */


string nome1, nome2;
int idade1, idade2;
double altura1, altura2;

Console.WriteLine("Informe o nome do atleta 1: ");
nome1 = Console.ReadLine();
Console.WriteLine("Informe a idade do atleta 1: ");
idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a altura do atleta 1: ");
altura1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o nome do atleta 2: ");
nome2 = Console.ReadLine();
Console.WriteLine("Informe a idade do atleta 2: ");
idade2 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a altura do atleta 2: ");
altura2 = double.Parse(Console.ReadLine());

if(idade1<idade2)
{
    Console.WriteLine("O atleta mais novo é: " + nome1);
}
else
{
    Console.WriteLine("O atleta mais novo é: " + nome2);
}
if(altura1>altura2)
{
    Console.WriteLine("O atleta mais alto é: " + nome1);
}
else
{
    Console.WriteLine("O atleta mais alto é: " + nome2);
}