/*Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.
*/

double kmInicio;
double kmFinal;
double litro;
double valorRecebido;
double precoCombustivel = 6.90;

Console.WriteLine("Informe a marcação do odômetro no ínicio do dia:");
kmInicio = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a marcação do odômetro no final do dia:");
kmFinal = double.Parse(Console.ReadLine());

Console.WriteLine("Informe quantos litros gastos:");
litro = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor total recebido dos passageiros:");
valorRecebido = double.Parse(Console.ReadLine());

double kmTotal = kmFinal - kmInicio ;
double consumoMedio = kmTotal / litro;

double lucro = valorRecebido - (litro*precoCombustivel);
Console.WriteLine("A média do consumo foi de " + consumoMedio + "  Km/l " + " e o lucro líquido do dia foi de R$ " + lucro);
