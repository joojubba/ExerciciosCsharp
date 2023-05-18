/*Popule uma matriz 5x5 e informe:
-Quantos números são pares
-Quantos números são impares
-Quantos números são positivos
-Quantos números são negativos
-Quantos zeros existem!
 * */

int[,] matriz = new int[5, 5];
int par = 0, impar = 0, positivo = 0, negativo = 0, zero = 0;


for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write("Informe um valor para cada linha " + i + " da coluna " +
            +j + ": ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {

        if (matriz[i, j] % 2 == 0)
        {
            matriz[i, j] = par;
            par += 1;
        }
        else
        {
            matriz[i, j] = impar;
            impar += 1;
        }
        if (matriz[i, j] < 0)
        {
            matriz[i, j] = negativo;
            negativo += 1;
        }
        else if(matriz[i, j] > 0)
        {
            matriz[i, j] = positivo;
            positivo += 1;
        }
        else
        {
            matriz[i, j] = zero;
            zero += 1;
        }
       
    }
}



Console.WriteLine("A quantidade de números pares é " + par);
Console.WriteLine("A quantidade de números ímpares é " + impar);
Console.WriteLine("A quantidade de números positivos é " + positivo);
Console.WriteLine("A quantidade de números negativos é " + negativo);
Console.WriteLine("A quantidade de números zero é " + zero);
