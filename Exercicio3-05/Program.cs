/*5. Escreva um algoritmo para calcular o fatorial de um número.
 * */

double numero;
double fatorial = 1;

Console.WriteLine("Informe um número: ");
numero = double.Parse(Console.ReadLine());

while (numero != 1)
{
    fatorial *= numero;
    numero -=  1;
}
Console.WriteLine("Fatorial: " + fatorial);