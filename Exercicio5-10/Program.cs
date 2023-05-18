/*Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
 * */


Random randomA = new Random();
int[,] matrizA = new int[4, 4];
Random randomB = new Random();
int[,] matrizB = new int[4, 4];
int[,] matrizC = new int[4, 4];
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

for (i = 0; i < matrizB.GetLength(0); i++)
{
    for (j = 0; j < matrizB.GetLength(1); j++)
    {
        matrizB[i, j] = randomB.Next(-10, 10);
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
        matrizC[i, j] = (matrizA[i, j] + matrizB[i, j])/2;
    }

}

Console.WriteLine("Matriz resultado da média: ");
for (i = 0; i < matrizC.GetLength(0); i++)
{
    for (j = 0; j < matrizC.GetLength(1); j++)
    {
        Console.Write(matrizC[i, j] + "\t");
    }
    Console.WriteLine();
}

int mediaC = 0;
int soma = 0;

for (i = 0; i < matrizC.GetLength(0); i++)
{
    for (j = 0; j < matrizC.GetLength(1); j++)
    {
        soma += matrizC[i, j];
        mediaC =  soma / 16;
    }
}

Console.WriteLine("Valor da média é: " + mediaC);

for (i = 0; i < matrizC.GetLength(0); i++)
{
    for (j = 0; j < matrizC.GetLength(1); j++)
    {
        if (matrizC[i, j] < mediaC)
        {
            Console.WriteLine("O número abaixo da média da posição: " + i + " da coluna " +
            +j + " é : " + matrizC[i, j]);
        }
        if (matrizC[i, j] > mediaC)
        {
            Console.WriteLine("O número acima da média da posição: " + i + " da coluna " +
            +j + " é : " + matrizC[i, j]);
        }
        if (matrizC[i, j] == mediaC)
        {
            Console.WriteLine("O número na média da posição: " + i + " da coluna " +
            +j + " é : " + matrizC[i, j]);
        }
    }
    Console.WriteLine();
}
