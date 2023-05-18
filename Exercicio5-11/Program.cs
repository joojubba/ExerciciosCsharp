/*Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.
 * */


Random randomA = new Random();
double[,] matrizA = new double[3, 3];
double[,] matrizB = new double[3, 3];
int i, j;

for (i = 0; i < matrizA.GetLength(0); i++)
{
    for (j = 0; j < matrizA.GetLength(1); j++)
    {
        matrizA[i, j] = randomA.Next(-10, 10);
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

double soma = 0;
for (i = 0; i < matrizA.GetLength(0); i++)
{
    for (j = 0; j < matrizA.GetLength(1); j++)
    {
        soma += matrizA[i, j];        
    }
}

for (i = 0; i < matrizB.GetLength(0); i++)
{
    for (j = 0; j < matrizB.GetLength(1); j++)
    {       
        matrizB[i, j] = matrizA[i, j] / soma ;
    }
}

Console.WriteLine("Matriz resultado da divisão dos elementos da matriz A pela soma dos seus indices: ");
for (i = 0; i < matrizB.GetLength(0); i++)
{
    for (j = 0; j < matrizB.GetLength(1); j++)
    {
        Console.Write(matrizB[i, j] + "\t");
    }
    Console.WriteLine();
}
