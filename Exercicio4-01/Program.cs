/*Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.
 * */

int[] vetor = new int[10];

int par = 0;
int impar = 0;

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um número: ");
    vetor[i] = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        i = par;
        par += 1;
    }
    else
    {
        i = impar;
        impar += 1;
    }

    Console.WriteLine("A quantidade de números pares é " + par);
    Console.WriteLine("A quantidade de números ímpares é " + impar);
}

