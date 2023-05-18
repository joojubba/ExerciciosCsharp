/* Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
 * */

int[,] matriz = new int[5, 3];
for (int i = 0; i < 5; i++)
{
    Console.Write("Informe um valor para a 1ª coluna: ");
    matriz[i, 0] = int.Parse( Console.ReadLine() );
    matriz[i, 1] = matriz[i, 0] + 10;
    matriz[i, 2] = matriz[i, 0] * 2;
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    
   Console.WriteLine();
}
