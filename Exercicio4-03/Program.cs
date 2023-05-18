/*Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.
 * */


int[] vetor = new int[20];
int cont = 0;

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um número para a posição " + i);
    vetor[i] = int.Parse(Console.ReadLine());

    do
    {
        if (vetor[i] <= 0)
        {
            Console.Write("Informe um número para a posição " + i );
            vetor[i] = int.Parse(Console.ReadLine());
        }
    } while (vetor[i] <= 0);       
}

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] % 2 == 1)
    {
        cont = i;
        Console.WriteLine("O número " + vetor[i] + " na  posição " + cont + " é primo ");
    }
}

