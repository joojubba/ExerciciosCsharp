/* Solicite ao usuário, preencher uma Matriz 3x3

Informe ao usuário:
*A soma dos elementos de cada linha
	-Ex: Linha 1: 30
	     Linha 2: 17
*A soma dos elementos de cada coluna
	-Ex: Coluna 1: 23
	     Coluna 2: 36
 * */

int[,] matriz = new int[3, 3];
int i, j, soma;

for (i = 0; i < matriz.GetLength(0); i++)
{
    for ( j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write("Informe um valor para cada linha " + i + " da coluna " +
            +j + ": ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

for ( i = 0; i < matriz.GetLength(0); i++)
{
    for ( j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

for ( i = 0; i < matriz.GetLength(0); i++)
{
    soma = 0;
    for ( j = 0; j < matriz.GetLength(1); j++)
    {
        soma += matriz[i, j];
    }
    Console.WriteLine("Soma da linha " + i + ": " + soma);
}

for ( j = 0; j < matriz.GetLength(1); j++)
{
    soma = 0;
    for ( i = 0; i < matriz.GetLength(0); i++)
    {
        soma += matriz[i, j];
    }
    Console.WriteLine("Soma da coluna " + j + ": " + soma);
}