// 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo,  o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.



Console.WriteLine("Informe o número do vendedor:");
int numeroVendedor = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o salário do vendedor:");
double salarioVendedor = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o percentual(comissão) do vendedor:");
double percentualVendas = double.Parse(Console.ReadLine());

double percentual = (percentualVendas / 100);
double total = percentual * salarioVendedor;
double totalVendedor = total + salarioVendedor;


Console.WriteLine("O vendedor " + numeroVendedor + " tem o salário total de R$ " + totalVendedor);
