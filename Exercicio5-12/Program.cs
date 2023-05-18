/* Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.
 * */

Random random = new Random();
int[,] matriz = new int[4, 3];
int i, j;

for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = random.Next(-10, 10);
    }
}

Console.WriteLine("Matriz: ");
for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

int soma = 0;

for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        soma = i + j;
        if(soma % 2 == 0)
        {
            Console.WriteLine("A soma dos índices ( " + i + " + " + j + " ) de valor " + matriz[i, j] + " é " + soma + " e é par" );
        }     
    }
    Console.WriteLine();
}

