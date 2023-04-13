/*Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
 * */

int a, b, c;

Console.WriteLine("Informe o valor 1: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor 2: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor 3: ");
c = int.Parse(Console.ReadLine());


if (a <= b && b <= c)
{
    Console.WriteLine(a + "," + b + "," + c);
}
else if (a <= c && c <= b)
{
    Console.WriteLine(a + "," + c + "," + b);
}
else if (b <= a && a <= c)
{
    Console.WriteLine(b + "," + a + "," + c);
}
else if (b <= c && c <= a)
{
    Console.WriteLine(b + "," + c + "," + a);
}
else if (c <= a && a <= b)
{
    Console.WriteLine(b + "," + c + "," + a);
}
else if (c <= b && b <= a)
{
    Console.WriteLine(c + "," + b + "," + a);
}
