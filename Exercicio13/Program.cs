/*Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado
*/


double salarioMinimo;
double precoDeCusto;
int bikeVendida;
double salarioVendedor;

Console.WriteLine("Informe o valor do salário mínimo em R$:");
salarioMinimo = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o preço de custo da bicicleta em R$:");
precoDeCusto = double.Parse(Console.ReadLine());

Console.WriteLine("Informe número de bicicletas vendidas:");
bikeVendida = int.Parse(Console.ReadLine());

double bikeTotal = bikeVendida * precoDeCusto;
salarioVendedor = (bikeTotal * 0.15) + (salarioMinimo*2);
Console.WriteLine("O salário do vendedor é de R$ " + salarioVendedor);

