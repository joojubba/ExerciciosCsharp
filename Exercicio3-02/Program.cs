/*2. Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
 * */

int n, numMaior;
Console.WriteLine("Informe um número: ");
numMaior = int.Parse(Console.ReadLine());

for (int i = 0; i < 9; i++)
{
    Console.WriteLine("Informe um número: ");
    n = int.Parse(Console.ReadLine());
    if (n > numMaior)
    {
        numMaior = n;
    }
}
Console.WriteLine("O maior número foi: " + numMaior);