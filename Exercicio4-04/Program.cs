/*Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, 
 * colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
 * */

int[] vetor1 = new int[10];
int[] vetor2 = new int[10];
int[] vetor3 = new int[10];

for (int i = 0; i < vetor1.Length; i++)
{
    Console.WriteLine("Informe um número: ");
    vetor1[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < vetor2.Length; i++)
{
    Console.WriteLine("Informe um número: ");
    vetor2[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < vetor3.Length; i++)
{
    vetor3[i] = vetor1[i] * vetor2[i];

    Console.WriteLine(" O vetor[" + i + "] = " + vetor1[i] + " x " + "vetor[" + i + "] = " + vetor2[i]);
    Console.WriteLine("Resultado: " + vetor3[i]);
}