/*Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
 * */


Random random = new Random();
int[,] matriz = new int[4, 4];
int i, j;

for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = random.Next(-100, 100);
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

Console.WriteLine("Matriz invertida: ");
for (i = 3; i >= 0; i--)
{
    for (j = 3; j >= 0; j--)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}
