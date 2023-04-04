// 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

Console.WriteLine(" ## Calculando a média aritmética de quatro valores ##");

Console.WriteLine("Digite o valor 1: ");
double valor1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor 2: ");
double valor2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor 3: ");
double valor3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor 4: ");
double valor4 = double.Parse(Console.ReadLine());
double soma = valor1 + valor2 + valor3 + valor4;
double media = soma / 4;
Console.WriteLine("A Média aritmética dos valores é de: " + media);