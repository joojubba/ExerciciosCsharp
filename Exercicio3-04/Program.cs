/*4. Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
elevado na y sem utilizar a função pow.
 * */

int x,y;
int potencia = 1;

Console.WriteLine("Informe o valor de x: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de y: ");
y = int.Parse(Console.ReadLine());

for (int i = 1; i <= y; i++)
{
	potencia *= x;
}

Console.WriteLine("“A potência de " + x + " ^ a " + y + " é: " + potencia);
