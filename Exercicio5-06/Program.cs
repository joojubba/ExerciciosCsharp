/* Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
Random random = new Random();
int randomNumber = random.Next(0, 100);
 * */

Random random = new Random();
int[,] matriz = new int[4,4];
int i, j, maior;
maior = matriz[0,0];

for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = random.Next(0, 9);
    }
}

for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        if(i == 0 && j == 0)
        {
            maior = matriz[0, 0];
        }
        if (matriz[i, j] > maior)
        {
            maior = matriz[i, j];
        }   
    }
}

Console.WriteLine("O maior número da matriz é: " + maior);
