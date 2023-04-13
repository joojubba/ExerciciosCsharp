/*Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
 * */

int a, b, c;

Console.WriteLine("Informe o tamanho do lado a: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o tamanho do lado b: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o tamanho do lado c: ");
c = int.Parse(Console.ReadLine());

if (a + b > c && a + c > b && b + c > a)
{
    Console.Write("Triângulo: ");
    if (a == b && a == c)
    {
        Console.WriteLine("Equilátero");
    }

    else
    {
        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Isoceles");
        }

        else
        {
            Console.WriteLine("Escaleno");
        }

    }
}