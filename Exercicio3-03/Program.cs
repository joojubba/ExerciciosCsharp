/*3. Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
x lido utilizando laços de repetição, e mostre na tela.
 * */

int x;

Console.WriteLine("Informe um número: ");
x = int.Parse(Console.ReadLine());


for(int i = 1; i < 11; i++)
{
    Console.WriteLine(x + " x " + i + " = " + (x*i) + "\n");
}