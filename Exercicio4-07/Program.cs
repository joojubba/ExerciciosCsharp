﻿/*Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|
 * */

int[] vetor = new int[10];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um número para a posição " + i);
    vetor[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < vetor.Length; i++)
{
    if(vetor[i] % 2== 0)
    {
        Console.Write("|" + vetor[i] + "|");
    }
}

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] % 2 != 0)
    {
        Console.Write("|" + vetor[i] + "|");
    }
}