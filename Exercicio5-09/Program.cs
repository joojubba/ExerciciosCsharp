/* Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
 * */

Random random = new Random();
int[,] matriz = new int[3, 3];
int i, j, num, elem;
bool exist = false;

for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = random.Next(-100, 100);
       
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

Console.Write("Informe um valor: ");
num = int.Parse(Console.ReadLine());

for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {


        if (matriz[i,j] == num)
        {
            exist = true;
        }
    }
}

if (exist)
{
    Console.WriteLine("O número existe no vetor");
}
else
{
    Console.WriteLine("Número inexistente");
}
