//1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.


Console.WriteLine(" ## Calculando a média aritmética de dois valores ##");

Console.WriteLine("Digite o valor 1: ");
double valor1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor 2: ");
double valor2 = double.Parse(Console.ReadLine());
double media = (valor1 + valor2) / 2;
Console.WriteLine("A Média aritmética dos valores é de: " + media);