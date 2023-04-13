/*7. Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
um usuário. Apresente o resultado.
 * */

int num;
int par = 0;
int impar = 0;

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Informe um número: ");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        num = par;
        par += 1;
    }
    else
    {
        num = impar;
        impar += 1;
    }

    Console.WriteLine("A quantidade de números pares é " + par);
    Console.WriteLine("A quantidade de números ímpares é " + impar);

}