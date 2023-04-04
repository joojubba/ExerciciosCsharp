// 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem de IPI (única) a ser acrescentada. 

Console.WriteLine("Informe o codigo do produto:");
int parafusoA = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o preço do produto:");
double precoA = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o percentual de IPI do produto:");
double percentualA = double.Parse(Console.ReadLine()); 

Console.WriteLine("Informe o codigo do produto:");
int parafusoB = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o preço do produto:");
double precoB = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o percentual de IPI do produto:");
double percentualB = double.Parse(Console.ReadLine());

double dadosA = precoA + (precoA*percentualA);
double dadosB = precoB + (precoB * percentualB);

Console.WriteLine("O valor do produto " + parafusoA + " é R$ " + precoA + " e seu percentual de IPI é " + percentualA + "%");
Console.WriteLine("O valor do produto " + parafusoB + " é R$ " + precoB + " e seu percentual de IPI é " + percentualB + "%");