/*Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

 * */

int[] vetor1 = new int[20];
int[] vetor2 = new int[20];
int[] vetor3 = new int[20];

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
    vetor3[i] = vetor1[i] + vetor2[i];

    Console.WriteLine(" O vetor[" + i + "] = " + vetor1[i] + " + " + "vetor[" + i + "] = " + vetor2[i]);
    Console.WriteLine("Resultado: " + vetor3[i]);
   
}