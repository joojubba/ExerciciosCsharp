/*Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
 * */

int[,] matriz = new int[4, 4];

for (int i = 0; i < 4; i++)
{
   
    for (int j = 0; j < 4; j++)
    {
        Console.Write("Informe um valor para cada linha " + i + " da coluna " +
            + j + ": ");
        matriz[i, j] = int.Parse(Console.ReadLine());

    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }

    Console.WriteLine();
}


for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < 1; j++)
    {
        Console.WriteLine("Diagonal: " + matriz[0,0] + matriz[1, 1] + matriz[2, 2] + matriz[3, 3]);
    }
    Console.WriteLine();
}