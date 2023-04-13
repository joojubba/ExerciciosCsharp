/*Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
 * */

int a, b, c;

Console.WriteLine("Informe o valor 1: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor 2: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor 3: ");
c = int.Parse(Console.ReadLine());

if(a > b && a > c)
{
    Console.WriteLine("O maior valor é: " + a);
}
if(b > c && b > a)
{
    Console.WriteLine("O maior valor é: " + b);
}
if (c > a && c > b)
{
    Console.WriteLine("O maior valor é: " + c);
}