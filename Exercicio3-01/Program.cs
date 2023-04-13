/*1. Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n 
pessoas e calcular a média das idades.
 * */

int i, n, idade, media;
int idadeTotal = 0;

Console.WriteLine("Informe um número: ");
n = int.Parse(Console.ReadLine());

for ( i = 1; i <= n; i++)
{
    Console.WriteLine("Informe a idade:");
    idade = int.Parse(Console.ReadLine());

    idadeTotal += idade;
}

media = idadeTotal / n;

Console.WriteLine("A média das idades é de: " + media);
