/*Leia duas matrizes 2x3 de números double. 
Imprima a soma destas duas matrizes.
 * */

int[,] matriz = new int[2, 3];
int[,] matrizX = new int[2, 3];
int[,] matrizY = new int[2, 3];
int i, j;


for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write("Informe um valor para cada linha " + i + " da coluna " +
            +j + ": ");
        matriz[i, j] = int.Parse(Console.ReadLine());
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
for (i = 0; i < matrizX.GetLength(0); i++)
{
    for (j = 0; j < matrizX.GetLength(1); j++)
    {
        Console.Write("Informe um valor para cada linha " + i + " da coluna " +
            +j + ": ");
        matrizX[i, j] = int.Parse(Console.ReadLine());
    }
}

for (i = 0; i < matrizX.GetLength(0); i++)
{
    for (j = 0; j < matrizX.GetLength(1); j++)
    {
        Console.Write(matrizX[i, j] + "\t");
    }
    Console.WriteLine();
}

for (i = 0; i < matrizY.GetLength(0); i++)
{
    
    for (j = 0; j < matrizY.GetLength(1); j++)
    {
        matrizY[i, j]  =  matriz[i, j] + matrizX[i, j];
    }

}
Console.WriteLine("Resultado da soma: ");
for (i = 0; i < matrizY.GetLength(0); i++)
{
    for (j = 0; j < matrizY.GetLength(1); j++)
    {
        Console.Write(matrizY[i, j] + "\t");
    }
    Console.WriteLine();
}



