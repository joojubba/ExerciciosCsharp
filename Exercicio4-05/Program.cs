/*Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
 * */

int[] vetor = new int[80];
int cont = 0;
int menor = 0;

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um número para a posição " + i);
    vetor[i] = int.Parse(Console.ReadLine());

    if(i==0)
    {
        menor = vetor[0];
    }

    if (vetor[i] < menor)
    {

        menor = vetor[i];
        cont = i;
    }
}
Console.WriteLine("O menor número é " + menor + " na  posição " + cont);
