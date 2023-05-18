/* Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.
 * */

Random randomA = new Random();
int[,] matrizA = new int[3, 3];
Random randomB = new Random();
int[,] matrizB = new int[3, 3];
int[,] matrizC = new int[3, 3];
int i, j;

for (i = 0; i < matrizA.GetLength(0); i++)
{
    for (j = 0; j < matrizA.GetLength(1); j++)
    {
        matrizA[i, j] = randomA.Next(-100, 100);
    }
}
Console.WriteLine("Matriz A: ");
for (i = 0; i < matrizA.GetLength(0); i++)
{
    for (j = 0; j < matrizA.GetLength(1); j++)
    {
        Console.Write(matrizA[i, j] + "\t");
    }
    Console.WriteLine();
}

for (i = 0; i < matrizB.GetLength(0); i++)
{
    for (j = 0; j < matrizB.GetLength(1); j++)
    {
        matrizB[i, j] = randomB.Next(-100, 100);
    }
}
Console.WriteLine("Matriz B: ");
for (i = 0; i < matrizB.GetLength(0); i++)
{
    for (j = 0; j < matrizB.GetLength(1); j++)
    {
        Console.Write(matrizB[i, j] + "\t");
    }
    Console.WriteLine();
}

for (i = 0; i < matrizC.GetLength(0); i++)
{
    
    for (j = 0; j < matrizC.GetLength(1); j++)
    {
        matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
    }

}
Console.WriteLine("Resultado da subtração: ");
for (i = 0; i < matrizC.GetLength(0); i++)
{
    for (j = 0; j < matrizC.GetLength(1); j++)
    {
        Console.Write(matrizC[i, j] + "\t");
    }
    Console.WriteLine();
}
